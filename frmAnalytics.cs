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
    public partial class frmAnalytics : Form
    {
        public frmAnalytics()
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
        public void GetHighRankedVideos()
        {

            // IF YOU EVER REMAKE THE MODULE 8 VIDEO, PLEASE TEACH STUDENTS THAT
            // THEY CAN MAKE MORE THAN BOILERPLATE CODE
            // WITH FUNCTIONS THAT GET THEIR CUSTOM CONTROLS
            // THANK YOU :)
            clsData VideoData = new clsData();

            VideoData.SQL = "SELECT VideoURL, VideoTitle, ThumbNail, Likes, Dislikes, Views FROM tblVideos ORDER BY Likes DESC";
            GetVideoStats(viMostLiked, VideoData);
            VideoData.SQL = "SELECT VideoURL, VideoTitle, ThumbNail, Likes, Dislikes, Views FROM tblVideos ORDER BY Dislikes DESC";
            GetVideoStats(viMostDisliked, VideoData);
            VideoData.SQL = "SELECT VideoURL, VideoTitle, ThumbNail, Likes, Dislikes, Views FROM tblVideos ORDER BY Views DESC";
            GetVideoStats(viMostViewed, VideoData);

            VideoData.SQL = "SELECT First(tblVideos.VideoID) AS [VideoID], Count(tblVideos.VideoID) AS NumOfDups FROM tblVideos GROUP BY tblVideos.VideoID HAVING Count(tblVideos.VideoID) > 1";
            string strVideoID = VideoData.dt.Rows[0]["VideoID"].ToString();
            VideoData.SQL = "SELECT VideoURL, VideoTitle, ThumbNail, Likes, Dislikes, Views FROM tblVideos WHERE VideoID = '" + strVideoID + "'";
            GetVideoStats(viTrending, VideoData);
        }

        public void GetVideoStats(VideoControl.VideoInfo video, clsData data)
        {
            video.URL = data.dt.Rows[0]["VideoURL"].ToString();
            video.VideoTitle = data.dt.Rows[0]["VideoTitle"].ToString();
            video.VideoImage = data.dt.Rows[0]["ThumbNail"].ToString();
            video.VideoLikes = int.Parse(data.dt.Rows[0]["Likes"].ToString());
            video.VideoDislikes = int.Parse(data.dt.Rows[0]["Dislikes"].ToString());
            video.VideoViews = int.Parse(data.dt.Rows[0]["Views"].ToString());
        }

        private void frmAnalytics_Load(object sender, EventArgs e)
        {
            ScreenDesign();
            GetHighRankedVideos();
            GetVideoCount();
        }

        private void GetVideoCount()
        {
            clsData VideoCount = new clsData();
            VideoCount.SQL = "SELECT COUNT (ID) AS NumVideos FROM tblVideos";
            tmrSystemVideos.Tag = VideoCount.dt.Rows[0]["NumVideos"].ToString();
            tmrSystemVideos.Start();
        }

        private void tmrSystemVideos_Tick(object sender, EventArgs e)
        {
            int intTotalCount = Convert.ToInt32(tmrSystemVideos.Tag);
            int intCurrentCount = Convert.ToInt32(lblVideosAnalyzed.Text);
            var random = new Random();
            int intIncrement = random.Next(600, 800);
            if (intCurrentCount + intIncrement >= intTotalCount)
            {
                lblVideosAnalyzed.Text = intTotalCount.ToString();
                tmrSystemVideos.Stop();
            }
            else
            {
                intCurrentCount += intIncrement;
                lblVideosAnalyzed.Text = intCurrentCount.ToString();
            }
        }
    }
}
