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
    public partial class formHome : Form
    {
        public void hidePanels()
        {
            pnlWelcome.Visible = false;
            pnlContact.Visible = false;
        }

        public formHome(string username)
        {
            InitializeComponent();
            lblUser.Text = username;
        }

        private void formHome_Load(object sender, EventArgs e)
        {
            hidePanels();
            pnlWelcome.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Size = new Size(21, 21);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Size = new Size(20, 20);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.Size = new Size(21, 21);
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.Size = new Size(20, 20);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            hidePanels();
            pnlWelcome.Visible = true;
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.BackgroundImage = SeasideSouthPark.Properties.Resources.btnsearchhover;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackgroundImage = SeasideSouthPark.Properties.Resources.btnsearch;
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            hidePanels();
            pnlContact.Visible = true;
        }

        private void btnContact_MouseEnter(object sender, EventArgs e)
        {
            btnContact.BackgroundImage = SeasideSouthPark.Properties.Resources.btncontacthover;
        }

        private void btnContact_MouseLeave(object sender, EventArgs e)
        {
            btnContact.BackgroundImage = SeasideSouthPark.Properties.Resources.btncontact;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            formAbout frmAbout = formAbout.getInstance();
            frmAbout.Show();
        }

        private void btnAbout_MouseEnter(object sender, EventArgs e)
        {
            btnAbout.BackgroundImage = SeasideSouthPark.Properties.Resources.btnabouthover;
        }

        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            btnAbout.BackgroundImage = SeasideSouthPark.Properties.Resources.btnabout;
        }

        private void btnMngAcc_Click(object sender, EventArgs e)
        {
            formAccount frmAccount = new formAccount(lblUser.Text);
            frmAccount.Show();
            this.Hide();
        }

        private void btnMngAcc_MouseEnter(object sender, EventArgs e)
        {
            btnMngAcc.BackgroundImage = SeasideSouthPark.Properties.Resources.btnmngacchover;
        }

        private void btnMngAcc_MouseLeave(object sender, EventArgs e)
        {
            btnMngAcc.BackgroundImage = SeasideSouthPark.Properties.Resources.btnmngacc;
        }

        private void btnSignOut_MouseEnter(object sender, EventArgs e)
        {
            btnSignOut.BackgroundImage = SeasideSouthPark.Properties.Resources.btnsignouthover;
        }

        private void btnSignOut_MouseLeave(object sender, EventArgs e)
        {
            btnSignOut.BackgroundImage = SeasideSouthPark.Properties.Resources.btnsignout;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            formLogin frmLogin = new formLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void linkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formLogin frmLogin = new formLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void linkManageAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formAccount frmAccount = new formAccount(lblUser.Text);
            frmAccount.Show();
            this.Hide();
        }

        private void linkNimesh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:linkNimesh.Text");
        }

        private void linkSahan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:linkSahan.Text");
        }

        private void linkAnu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:linkAnu.Text");
        }

        private void linkFeedback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:linkFeedback.Text");
        }
    }
}
