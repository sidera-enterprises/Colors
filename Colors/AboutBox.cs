using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colors
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();

            Version v = Assembly.GetExecutingAssembly().GetName().Version;

            lblAppVer.Text = string.Format("v{0}.{1}.{2}.{3}",
                v.Major, v.Minor, v.Build, v.Revision);
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {

        }

        private void lnkAppLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tcTabs.SelectedIndex = 1;
        }

        private void lnkFollow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = "https://github.com/sidera-enterprises/Colors",
                UseShellExecute = true
            };

            Process.Start(psi);
        }

        private void lnkHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = "https://sidera.dev/",
                UseShellExecute = true
            };

            Process.Start(psi);
        }
    }
}
