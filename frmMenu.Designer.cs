
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
            this.btnImport = new System.Windows.Forms.Button();
            this.btnVideoAnalytics = new System.Windows.Forms.Button();
            this.btnViewVideos = new System.Windows.Forms.Button();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.btnViewVideos);
            this.pnlOptions.Controls.Add(this.btnVideoAnalytics);
            this.pnlOptions.Controls.Add(this.btnImport);
            this.pnlOptions.Location = new System.Drawing.Point(13, 266);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(298, 178);
            this.pnlOptions.TabIndex = 0;
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
            // btnVideoAnalytics
            // 
            this.btnVideoAnalytics.Location = new System.Drawing.Point(3, 62);
            this.btnVideoAnalytics.Name = "btnVideoAnalytics";
            this.btnVideoAnalytics.Size = new System.Drawing.Size(292, 53);
            this.btnVideoAnalytics.TabIndex = 0;
            this.btnVideoAnalytics.Text = "Video Analytics";
            this.btnVideoAnalytics.UseVisualStyleBackColor = true;
            // 
            // btnViewVideos
            // 
            this.btnViewVideos.Location = new System.Drawing.Point(3, 121);
            this.btnViewVideos.Name = "btnViewVideos";
            this.btnViewVideos.Size = new System.Drawing.Size(292, 53);
            this.btnViewVideos.TabIndex = 0;
            this.btnViewVideos.Text = "View Videos";
            this.btnViewVideos.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 456);
            this.Controls.Add(this.pnlOptions);
            this.Name = "frmMenu";
            this.Text = "Awesome Videos | Menu";
            this.pnlOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnViewVideos;
        private System.Windows.Forms.Button btnVideoAnalytics;
        private System.Windows.Forms.Button btnImport;
    }
}

