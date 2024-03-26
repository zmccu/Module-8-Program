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

namespace Module_8
{
    public partial class frmImport : Form
    {
        public frmImport()
        {
            InitializeComponent();
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
            }
            btnImport.Enabled = !btnImport.Enabled;
            btnClose.Enabled = !btnClose.Enabled;
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
            UpdateStatusList("Waiting for file import...");
        }
    }
}
