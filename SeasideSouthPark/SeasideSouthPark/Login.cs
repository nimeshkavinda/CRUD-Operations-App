﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SeasideSouthPark
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            String path = Path.Combine(documents, "SeasideSouthPark\\Image");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Size = new Size(21,21);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Size = new Size(20, 20);
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
            if (txtUserName.Text.Length<1)
            {
                txtUserName.Text = "Username";
                txtUserName.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text == "Password")
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
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formSignUp frmSignUp = new formSignUp();
            frmSignUp.Show();
            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Global.ConnectionString);
            string qry = "Select * from tblUser where Username='" + txtUserName.Text.Trim() + "' and Password='" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(qry, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            try
            {
                if (dtbl.Rows.Count == 1)
                {
                    formHome frmHome = new formHome(txtUserName.Text.Trim());
                    frmHome.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Please check your username and password");
                }
            }
            
            catch(Exception ex)
            {
                MessageBox.Show("Login Failed, Error Generated: " + ex);
            }

            finally
            {
                txtUserName.Text = "Username";
                txtUserName.ForeColor = Color.Gray;

                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
            }
        }
    }
}
