using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Module_8
{
    class clsVideoDetail
    {

        public clsVideoDetail(string _VideoID, string _VideoTrendingDate, string _VideoTitle, string _VideoTags, string _VideoViews, string _VideoLikes, string _VideoDislikes, string _VideoThumbnail, string _VideoDescription)
        {
            VideoID = _VideoID;
            VideoURL = "https://www.youtube.com/watch?v=" + VideoID;
            // date handling
            string tempYear;
            // Does this even do anything?
            // The trending date will *always* be less than current date, videos can't trend in the future
            if (Convert.ToInt32(_VideoTrendingDate.Substring(0,2)) < Convert.ToInt32(Convert.ToString(DateTime.Now.Year).Substring(2, 2)))
            {
                tempYear = "20" + _VideoTrendingDate.Substring(0, 2);
            }
            else
            {
                // There are no videos uploaded to YouTube that trended in the 19XXs
                tempYear = "19" + _VideoTrendingDate.Substring(0, 2);
            }
            CultureInfo culture = new CultureInfo("en-US");
            DateTime tempDate = Convert.ToDateTime(_VideoTrendingDate.Substring(6, 2) + "/" + _VideoTrendingDate.Substring(3, 2) + "/" + tempYear, culture);
            VideoTitle = _VideoTitle.Replace("'","");
            if (VideoTitle.Length > 2)
            {
                VideoTitle = VideoTitle.Substring(1, VideoTitle.Length - 2);
            }
            VideoTags = _VideoTags.Replace("'", "");
            if (VideoTags.Length > 2)
            {
                VideoTags = VideoTags.Substring(1, VideoTags.Length - 2);
            }
            VideoViews = Convert.ToInt64(_VideoViews);
            VideoLikes = Convert.ToInt64(_VideoLikes);
            VideoDislikes = Convert.ToInt64(_VideoDislikes);
            VideoThumbnail = _VideoThumbnail;
            VideoDescription = _VideoDescription.Replace("'", "");
            if (VideoDescription.Length > 2)
            {
                VideoDescription = VideoDescription.Substring(1, VideoDescription.Length - 2);
            }

        }

        public string VideoID { get; }
        public string VideoURL { get; }
        public DateTime VideoTrendingDate { get; }
        public string VideoTitle { get; }
        public string VideoTags { get; }
        public long VideoViews { get; }
        public long VideoLikes { get; }
        public long VideoDislikes { get; }
        public string VideoThumbnail { get; }
        public string VideoDescription{ get; }

    }
}
