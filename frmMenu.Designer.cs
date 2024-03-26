
namespace Module_8
{
    partial class frmMenu
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
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnViewVideos = new System.Windows.Forms.Button();
            this.btnVideoAnalytics = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.btnViewVideos);
            this.pnlOptions.Controls.Add(this.btnVideoAnalytics);
            this.pnlOptions.Controls.Add(this.btnImport);
            this.pnlOptions.Location = new System.Drawing.Point(96, 266);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(298, 178);
            this.pnlOptions.TabIndex = 0;
            // 
            // btnViewVideos
            // 
            this.btnViewVideos.Location = new System.Drawing.Point(3, 121);
            this.btnViewVideos.Name = "btnViewVideos";
            this.btnViewVideos.Size = new System.Drawing.Size(292, 53);
            this.btnViewVideos.TabIndex = 0;
            this.btnViewVideos.Text = "View Videos";
            this.btnViewVideos.UseVisualStyleBackColor = true;
            this.btnViewVideos.Click += new System.EventHandler(this.btnViewVideos_Click);
            // 
            // btnVideoAnalytics
            // 
            this.btnVideoAnalytics.Location = new System.Drawing.Point(3, 62);
            this.btnVideoAnalytics.Name = "btnVideoAnalytics";
            this.btnVideoAnalytics.Size = new System.Drawing.Size(292, 53);
            this.btnVideoAnalytics.TabIndex = 0;
            this.btnVideoAnalytics.Text = "Video Analytics";
            this.btnVideoAnalytics.UseVisualStyleBackColor = true;
            this.btnVideoAnalytics.Click += new System.EventHandler(this.btnVideoAnalytics_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(3, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(292, 53);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import Video Data";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(16, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 456);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.pnlOptions);
            this.Name = "frmMenu";
            this.Text = "Awesome Videos | Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnViewVideos;
        private System.Windows.Forms.Button btnVideoAnalytics;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.PictureBox picLogo;
    }
}

