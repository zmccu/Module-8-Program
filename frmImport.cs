using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Module_8
{
    public partial class frmImport : Form
    {

        static Regex re = new Regex("(?:^|,)(\"(?:[^\"]+|\"\")*\"|[^,]*)", RegexOptions.Compiled);

        public frmImport()
        {
            InitializeComponent();
        }
        public void ScreenDesign()
        {
            BackColor = Color.FromName(clsGlobal.ProgramBackgroundColor);
            ForeColor = Color.FromName(clsGlobal.ProgramForeColor);
            picLogo.Image = Image.FromFile(clsGlobal.ProgramLogo);
            Icon = new Icon(clsGlobal.ProgramIcon);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            btnImport.Enabled = !btnImport.Enabled;
            btnClose.Enabled = !btnClose.Enabled;

            ofdImport = new OpenFileDialog();
            ofdImport.Title = "Browse for CSV Import Files";
            ofdImport.DefaultExt = "csv";
            ofdImport.ShowDialog();
            if (ofdImport.CheckFileExists == true)
            {
                int intRecordCount = CleanDataSource(ofdImport.FileName);
                ImportVideosFromCSV(intRecordCount);
            }
            btnImport.Enabled = !btnImport.Enabled;
            btnClose.Enabled = !btnClose.Enabled;
        }

        public void ImportVideosFromCSV(int totalAmount = 0, string path = "VideoImport.csv")
        {
            List<clsVideoDetail> VideoList = new List<clsVideoDetail>();
            int count = 0;
            string line;
            clsData DeleteData = new clsData();
            DeleteData.DeleteRecord("DELETE * FROM tblVideos");
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                count++;
                UpdateStatusList($"{count.ToString("N0")} of {totalAmount.ToString("N0")} records reviewed.");
                string[] columns = SplitCSV(line);
                if (columns[0].Trim() != "video_id" && columns.Length == 16)
                {
                    // 0: video_id > VideoID
                    // 1: trending_date > VideoTrendingDate
                    // 2: title > VideoTitle
                    // 6: tags > VideoTags
                    // 7: views > VideoViews
                    // 8: likes > VideoLikes
                    // 9: dislikes > VideoDislikes
                    // 11: thumbnail > VideoThumbnail
                    // 15: description > VideoDescription

                    clsVideoDetail newVideo = new clsVideoDetail(columns[0], columns[1], columns[2], columns[6], columns[7], columns[8], columns[9], columns[11], columns[15]);
                    VideoList.Add(newVideo);

                }
            }
            UpdateStatusList("Updating the database...");
            clsData NewVideoData = new clsData();
            NewVideoData.BatchAddVideos(VideoList);
            file.Close();
            UpdateStatusList("Import completed!");
        }

        private static string[] SplitCSV(string input)
        {
            List<string> list = new List<string>();
            string current = null;
            foreach (Match match in re.Matches(input))
            {
                current = match.Value;
                if (current.Length == 0)
                    list.Add("");
                list.Add(current.TrimStart(','));
            }
            return list.ToArray();
        }

        private int CleanDataSource(string path, string newPath="VideoImport.csv")
        {
            int count = 0;
            string line;
            StreamReader oldFile = new StreamReader(path);
            StreamWriter newFile = new StreamWriter(newPath);
            while ((line = oldFile.ReadLine()) != null)
            {
                if (line.StartsWith("\\n") == false)
                {
                    if (line.EndsWith("\"") == false)
                    {
                        line += "\"";
                        count++;
                        newFile.WriteLine(line);
                    }
                }
            }
            newFile.Close();
            oldFile.Close();
            UpdateStatusList($"{count} records to be imported.");
            return count;
        }

        private void UpdateStatusList(string status)
        {
            lstImports.Items.Add(status);
            lstImports.SelectedIndex = lstImports.Items.Count - 1;
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            ScreenDesign();
            UpdateStatusList("Waiting for file import...");
        }
    }
}
