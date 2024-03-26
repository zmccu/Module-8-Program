
namespace Module_8
{
    partial class frmVideo
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
            this.viVideo = new VideoControl.VideoInfo();
            this.cboVideo = new System.Windows.Forms.ComboBox();
            this.viRandom = new VideoControl.VideoInfo();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // viVideo
            // 
            this.viVideo.ControlTitle = "Selected Video";
            this.viVideo.Location = new System.Drawing.Point(12, 128);
            this.viVideo.Name = "viVideo";
            this.viVideo.Size = new System.Drawing.Size(223, 310);
            this.viVideo.TabIndex = 0;
            this.viVideo.URL = null;
            this.viVideo.VideoDislikes = 0;
            this.viVideo.VideoImage = null;
            this.viVideo.VideoLikes = 0;
            this.viVideo.VideoTitle = null;
            this.viVideo.VideoViews = 0;
            // 
            // cboVideo
            // 
            this.cboVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideo.FormattingEnabled = true;
            this.cboVideo.Location = new System.Drawing.Point(12, 101);
            this.cboVideo.Name = "cboVideo";
            this.cboVideo.Size = new System.Drawing.Size(462, 21);
            this.cboVideo.TabIndex = 1;
            this.cboVideo.SelectedIndexChanged += new System.EventHandler(this.cboVideo_SelectedIndexChanged);
            // 
            // viRandom
            // 
            this.viRandom.ControlTitle = "Random Video";
            this.viRandom.Location = new System.Drawing.Point(251, 128);
            this.viRandom.Name = "viRandom";
            this.viRandom.Size = new System.Drawing.Size(223, 310);
            this.viRandom.TabIndex = 2;
            this.viRandom.URL = null;
            this.viRandom.VideoDislikes = 0;
            this.viRandom.VideoImage = null;
            this.viRandom.VideoLikes = 0;
            this.viRandom.VideoTitle = null;
            this.viRandom.VideoViews = 0;
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // frmVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.viRandom);
            this.Controls.Add(this.cboVideo);
            this.Controls.Add(this.viVideo);
            this.Name = "frmVideo";
            this.Text = "Awesome Videos | View Videos";
            this.Load += new System.EventHandler(this.frmVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VideoControl.VideoInfo viVideo;
        private System.Windows.Forms.ComboBox cboVideo;
        private VideoControl.VideoInfo viRandom;
        private System.Windows.Forms.PictureBox picLogo;
    }
}