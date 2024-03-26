
namespace Module_8
{
    partial class frmAnalytics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.viMostLiked = new VideoControl.VideoInfo();
            this.viMostDisliked = new VideoControl.VideoInfo();
            this.viMostViewed = new VideoControl.VideoInfo();
            this.viTrending = new VideoControl.VideoInfo();
            this.lblVideosAnalyzed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrSystemVideos = new System.Windows.Forms.Timer(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // viMostLiked
            // 
            this.viMostLiked.ControlTitle = "Most Liked Video";
            this.viMostLiked.Location = new System.Drawing.Point(12, 128);
            this.viMostLiked.Name = "viMostLiked";
            this.viMostLiked.Size = new System.Drawing.Size(223, 310);
            this.viMostLiked.TabIndex = 0;
            this.viMostLiked.URL = null;
            this.viMostLiked.VideoDislikes = 0;
            this.viMostLiked.VideoImage = null;
            this.viMostLiked.VideoLikes = 0;
            this.viMostLiked.VideoTitle = null;
            this.viMostLiked.VideoViews = 0;
            // 
            // viMostDisliked
            // 
            this.viMostDisliked.ControlTitle = "Most Disliked Video";
            this.viMostDisliked.Location = new System.Drawing.Point(241, 128);
            this.viMostDisliked.Name = "viMostDisliked";
            this.viMostDisliked.Size = new System.Drawing.Size(223, 310);
            this.viMostDisliked.TabIndex = 1;
            this.viMostDisliked.URL = null;
            this.viMostDisliked.VideoDislikes = 0;
            this.viMostDisliked.VideoImage = null;
            this.viMostDisliked.VideoLikes = 0;
            this.viMostDisliked.VideoTitle = null;
            this.viMostDisliked.VideoViews = 0;
            // 
            // viMostViewed
            // 
            this.viMostViewed.ControlTitle = "Most Viewed Video";
            this.viMostViewed.Location = new System.Drawing.Point(470, 128);
            this.viMostViewed.Name = "viMostViewed";
            this.viMostViewed.Size = new System.Drawing.Size(223, 310);
            this.viMostViewed.TabIndex = 2;
            this.viMostViewed.URL = null;
            this.viMostViewed.VideoDislikes = 0;
            this.viMostViewed.VideoImage = null;
            this.viMostViewed.VideoLikes = 0;
            this.viMostViewed.VideoTitle = null;
            this.viMostViewed.VideoViews = 0;
            // 
            // viTrending
            // 
            this.viTrending.ControlTitle = "Most Trended Video";
            this.viTrending.Location = new System.Drawing.Point(699, 128);
            this.viTrending.Name = "viTrending";
            this.viTrending.Size = new System.Drawing.Size(244, 310);
            this.viTrending.TabIndex = 3;
            this.viTrending.URL = null;
            this.viTrending.VideoDislikes = 0;
            this.viTrending.VideoImage = null;
            this.viTrending.VideoLikes = 0;
            this.viTrending.VideoTitle = null;
            this.viTrending.VideoViews = 0;
            // 
            // lblVideosAnalyzed
            // 
            this.lblVideosAnalyzed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideosAnalyzed.Location = new System.Drawing.Point(12, 88);
            this.lblVideosAnalyzed.Name = "lblVideosAnalyzed";
            this.lblVideosAnalyzed.Size = new System.Drawing.Size(223, 37);
            this.lblVideosAnalyzed.TabIndex = 4;
            this.lblVideosAnalyzed.Text = "0";
            this.lblVideosAnalyzed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Videos Analyzed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrSystemVideos
            // 
            this.tmrSystemVideos.Tick += new System.EventHandler(this.tmrSystemVideos_Tick);
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(17, 13);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // frmAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVideosAnalyzed);
            this.Controls.Add(this.viTrending);
            this.Controls.Add(this.viMostViewed);
            this.Controls.Add(this.viMostDisliked);
            this.Controls.Add(this.viMostLiked);
            this.Name = "frmAnalytics";
            this.Text = "Awesome Videos | Video Analytics";
            this.Load += new System.EventHandler(this.frmAnalytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VideoControl.VideoInfo viMostLiked;
        private VideoControl.VideoInfo viMostDisliked;
        private VideoControl.VideoInfo viMostViewed;
        private VideoControl.VideoInfo viTrending;
        private System.Windows.Forms.Label lblVideosAnalyzed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrSystemVideos;
        private System.Windows.Forms.PictureBox picLogo;
    }
}