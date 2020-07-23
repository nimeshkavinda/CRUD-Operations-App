using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeasideSouthPark
{
    public partial class formAbout : Form
    {
        public formAbout()
        {
            InitializeComponent();
        }

        private static formAbout instance;

        public static formAbout getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new formAbout();
            else 
                instance.BringToFront();
            return instance;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Size = new Size(21, 21);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Size = new Size(20, 20);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/nimeshkavinda/CRUD-Operations-App");
        }

        private void linkXd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://xd.adobe.com/view/a46da8e8-5bd0-4e33-ab66-9976aaae1a55-f13e");
        }

        private void btnNimFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/nimeshkavinda13");
        }

        private void btnNimLi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/ukdnkavinda/");
        }

        private void btnNimGit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/nimeshkavinda");
        }

        private void btnSNFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/PnXKeiRa");
        }

        private void btnSNLi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/sahan-nishantha-5a04a91a4/");
        }

        private void btnSNGit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/sahan138");
        }

        private void btnANFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/anuda.nethmin.7");
        }

        private void btnANLi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/anuda-nethmin-67191614a/");
        }
    }
}
