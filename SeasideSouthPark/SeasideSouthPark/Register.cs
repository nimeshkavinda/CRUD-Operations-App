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
    public partial class formSignUp : Form
    {
        public formSignUp()
        {
            InitializeComponent();
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

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.Size = new Size(21, 21);
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Size = new Size(20, 20);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formLogin frmLogin = new formLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void txtFName_Enter(object sender, EventArgs e)
        {
            if (txtFName.Text == "First Name")
            {
                txtFName.Text = "";
                txtFName.ForeColor = Color.DimGray;
            }
        }

        private void txtFName_Leave(object sender, EventArgs e)
        {
            if (txtFName.Text.Length < 1)
            {
                txtFName.Text = "First Name";
                txtFName.ForeColor = Color.Gray;
            }
        }

        private void txtLName_Enter(object sender, EventArgs e)
        {
            if (txtLName.Text == "Last Name")
            {
                txtLName.Text = "";
                txtLName.ForeColor = Color.DimGray;
            }
        }

        private void txtLName_Leave(object sender, EventArgs e)
        {
            if (txtLName.Text.Length < 1)
            {
                txtLName.Text = "Last Name";
                txtLName.ForeColor = Color.Gray;
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Username")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.DimGray;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length < 1)
            {
                txtUserName.Text = "Username";
                txtUserName.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "E-mail")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.DimGray;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length < 1)
            {
                txtEmail.Text = "E-mail";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Mobile Number")
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = Color.DimGray;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length < 1)
            {
                txtPhone.Text = "Mobile Number";
                txtPhone.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 1)
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void txtConPassword_Enter(object sender, EventArgs e)
        {
            if (txtConPassword.Text == "Confirm Password")
            {
                txtConPassword.Text = "";
                txtConPassword.PasswordChar = '*';
                txtConPassword.ForeColor = Color.DimGray;
            }
        }

        private void txtConPassword_Leave(object sender, EventArgs e)
        {
            if (txtConPassword.Text.Length < 1)
            {
                txtConPassword.Text = "Confirm Password";
                txtConPassword.ForeColor = Color.Gray;
            }
        }

        private void linkLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formLogin frmLogin = new formLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
