using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

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

            if (!(txtEmail.Text=="E-mail"))
            {

                string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

                if (Regex.IsMatch(txtEmail.Text, pattern))
                {
                }
                else
                {
                    MessageBox.Show("Invalid Email address");
                    txtEmail.Text = "E-mail";
                    txtEmail.ForeColor = Color.Gray;
                }
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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(txtFName.Text=="First Name" || txtLName.Text=="Last Name" || txtUserName.Text=="Username" || txtEmail.Text=="E-mail" || txtPhone.Text=="Mobile Number" || txtPassword.Text=="Password" || txtConPassword.Text=="Confirm Password")
            {
                MessageBox.Show("Please fill in all the fields");
            }

            else if(!(txtPassword.Text == txtConPassword.Text))
            {
                MessageBox.Show("Passwords don't match");
            }
            
            else if (!(checkboxTerms.Checked))
            {
                MessageBox.Show("You need to accept terms & conditions");
            }

            else
            {
                string username = txtUserName.Text;
                string fname = txtFName.Text;
                string lname = txtLName.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string password = txtPassword.Text;

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\GitHub\CRUD-Operations-App\SeasideSouthPark\SeasideDB.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "Insert into tblUser Values ('" + username + "','" + fname + "','" + lname + "','" + email + "','" + phone + "','" + password + "','" + null +"','" + null + "')";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sign Up Successful, Please Log In");
                }

                catch(SqlException sqlex)
                {
                    if (sqlex.Number == 2627)
                    {
                        MessageBox.Show("Username already exist");
                    }

                    else
                    {
                        MessageBox.Show("Sign Up Unsuccessful, Error Generated: " + sqlex);
                    }
                }

                catch(Exception ex)
                {
                    MessageBox.Show("Sign Up Unsuccessful, Error Generated: " + ex);
                }

                finally
                {
                    txtFName.Text = "First Name";
                    txtFName.ForeColor = Color.Gray;

                    txtLName.Text = "Last Name";
                    txtLName.ForeColor = Color.Gray;

                    txtUserName.Text = "Username";
                    txtUserName.ForeColor = Color.Gray;

                    txtEmail.Text = "E-mail";
                    txtEmail.ForeColor = Color.Gray;

                    txtPhone.Text = "Mobile Number";
                    txtPhone.ForeColor = Color.Gray;

                    txtPassword.Text = "Password";
                    txtPassword.ForeColor = Color.Gray;

                    txtConPassword.Text = "Confirm Password";
                    txtConPassword.ForeColor = Color.Gray;

                    checkboxTerms.Checked = false;
                }
            }
        }
    }
}
