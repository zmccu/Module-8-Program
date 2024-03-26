using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_8
{
    public partial class frmVideo : Form
    {

        List<clsVideoDetail> VideoList = new List<clsVideoDetail>();

        public frmVideo()
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
        private void ListVideos()
        {
            VideoList.Clear();
            cboVideo.Items.Clear();
            clsData Videos = new clsData();
            Videos.SQL = "SELECT ID, VideoID, VideoTitle, ThumbNail, Likes, Dislikes, Views FROM tblVideos ORDER BY ID";
            for (int i = 0; i < Videos.dt.Rows.Count; i++)
            {
                clsVideoDetail tempVid = new clsVideoDetail(Videos.dt.Rows[i]["VideoID"].ToString(), Videos.dt.Rows[i]["VideoTitle"].ToString(), Videos.dt.Rows[i]["Views"].ToString(), Videos.dt.Rows[i]["Likes"].ToString(), Videos.dt.Rows[i]["Dislikes"].ToString(), Videos.dt.Rows[i]["ThumbNail"].ToString());
                VideoList.Add(tempVid);
                cboVideo.Items.Add(VideoList[VideoList.Count - 1].VideoTitle);
            }
        }

        private void frmVideo_Load(object sender, EventArgs e)
        {
            ScreenDesign();
            ListVideos();
        }

        private void cboVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            viVideo.QuickSettings(VideoList[cboVideo.SelectedIndex].VideoTitle, VideoList[cboVideo.SelectedIndex].VideoURL, VideoList[cboVideo.SelectedIndex].VideoThumbnail, int.Parse(VideoList[cboVideo.SelectedIndex].VideoLikes.ToString()), int.Parse(VideoList[cboVideo.SelectedIndex].VideoDislikes.ToString()), int.Parse(VideoList[cboVideo.SelectedIndex].VideoViews.ToString()));
            RandomVideo();
        }

        private void RandomVideo()
        {
            var random = new Random();
            int intRandom = random.Next(0, VideoList.Count);
            viRandom.QuickSettings(VideoList[intRandom].VideoTitle, VideoList[intRandom].VideoURL, VideoList[intRandom].VideoThumbnail, int.Parse(VideoList[intRandom].VideoLikes.ToString()), int.Parse(VideoList[intRandom].VideoDislikes.ToString()), int.Parse(VideoList[intRandom].VideoViews.ToString()));
        }
    }
}
