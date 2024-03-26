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
    public partial class frmMenu : Form
    {
        public frmMenu()
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
        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImport import = new frmImport();
            import.ShowDialog();
        }

        private void btnViewVideos_Click(object sender, EventArgs e)
        {
            frmVideo VideoForm = new frmVideo();
            VideoForm.ShowDialog();
        }

        private void btnVideoAnalytics_Click(object sender, EventArgs e)
        {
            frmAnalytics frmAnalytics = new frmAnalytics();
            frmAnalytics.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            ScreenDesign();
        }
    }
}
