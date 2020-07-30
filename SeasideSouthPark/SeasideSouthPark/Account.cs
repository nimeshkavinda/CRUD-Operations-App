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
using System.IO;
using System.Text.RegularExpressions;

namespace SeasideSouthPark
{
    public partial class formAccount : Form
    {
        string uName;

        public formAccount(string username)
        {
            uName = username;
            InitializeComponent();

            SqlConnection con = new SqlConnection(Global.ConnectionString);
            string qry = "Select FName,LName,Email,Phone,City,Country from tblUser where Username='" + uName + "'";
            SqlDataAdapter sda = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "tblUser");

            string firstname = ds.Tables[0].Rows[0][0].ToString();
            string lastname = ds.Tables[0].Rows[0][1].ToString();
            string email = ds.Tables[0].Rows[0][2].ToString();
            string phone = ds.Tables[0].Rows[0][3].ToString();
            string city = ds.Tables[0].Rows[0][4].ToString();
            string country = ds.Tables[0].Rows[0][5].ToString();

            lblFLName.Text = (firstname.Trim() + " " + lastname.Trim());
            lblUserEmail.Text = email.Trim();
            lblPNumber.Text = phone.Trim();
            lblCity.Text = city.Trim();
            lblCountry.Text = country.Trim();
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
            formHome frmHome = new formHome(uName);
            frmHome.Show();
            this.Hide();
        }

        string imgLoc = "";
        SqlConnection connection = new SqlConnection(Global.ConnectionString);
        SqlCommand command;

        private void linkImgUpload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image files | *.jpg";
                ofd.Title = "Choose image";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = ofd.FileName.ToString();
                    picboxUser.ImageLocation = imgLoc;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                img = br.ReadBytes((int)fs.Length);

                string query = "Update tblUser Set ProImg='" + @img + "' Where Username ='" + uName + "'";
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@img", img));
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Profile image has been updated, Please save changes");
            }
        }

        private void linkSaveImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string query = "Select ProImg from tblUser Where Username ='" + uName + "'";
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    byte[] img = (byte[])(reader[0]);
                    if (img == null)
                    {
                        picboxUser.Image = SeasideSouthPark.Properties.Resources.defaultUser;
                        MessageBox.Show("Image can not be found");
                    }

                    else
                    {
                        connection.Close();
                        MemoryStream ms = new MemoryStream(img);
                       // picboxUser.Image = Image.FromStream(ms);


                        byte[] getImg = new byte[0];
                        SqlCommand cmd = new SqlCommand("Select ProImg from tblUser Where Username = '" + uName + "'", connection);
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            getImg = (byte[])dr["ProImg"];
                        }

                        byte[] imgData = getImg;
                        MemoryStream stream = new MemoryStream(imgData);
                        var newImage = System.Drawing.Image.FromStream(stream);
                        stream.Dispose();
                        picboxUser.Image = newImage;



                    }
                }

                else
                {
                    MessageBox.Show("Image has not been saved properly");
                }

            }

            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Error generated: "+ex);
            }
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

            if (!(txtEmail.Text == "E-mail"))
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

        private void txtCity_Enter(object sender, EventArgs e)
        {
            if (txtCity.Text == "City")
            {
                txtCity.Text = "";
                txtCity.ForeColor = Color.DimGray;
            }
        }

        private void txtCity_Leave(object sender, EventArgs e)
        {
            if (txtCity.Text.Length < 1)
            {
                txtCity.Text = "City";
                txtCity.ForeColor = Color.Gray;
            }
        }

        private void txtCountry_Enter(object sender, EventArgs e)
        {
            if (txtCountry.Text == "Country")
            {
                txtCountry.Text = "";
                txtCountry.ForeColor = Color.DimGray;
            }
        }

        private void txtCountry_Leave(object sender, EventArgs e)
        {
            if (txtCountry.Text.Length < 1)
            {
                txtCountry.Text = "Country";
                txtCountry.ForeColor = Color.Gray;
            }
        }

        private void txtCurrentPass_Enter(object sender, EventArgs e)
        {
            if (txtCurrentPass.Text == "Current Password")
            {
                txtCurrentPass.Text = "";
                txtCurrentPass.PasswordChar = '*';
                txtCurrentPass.ForeColor = Color.DimGray;
            }
        }

        private void txtCurrentPass_Leave(object sender, EventArgs e)
        {
            if (txtCurrentPass.Text.Length < 1)
            {
                txtCurrentPass.PasswordChar = '\0';
                txtCurrentPass.Text = "Current Password";
                txtCurrentPass.ForeColor = Color.Gray;
            }
        }

        private void txtNewPass_Enter(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "New Password")
            {
                txtNewPass.Text = "";
                txtNewPass.PasswordChar = '*';
                txtNewPass.ForeColor = Color.DimGray;
            }
        }

        private void txtNewPass_Leave(object sender, EventArgs e)
        {
            if (txtNewPass.Text.Length < 1)
            {
                txtNewPass.PasswordChar = '\0';
                txtNewPass.Text = "New Password";
                txtNewPass.ForeColor = Color.Gray;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "First Name" || txtLName.Text == "Last Name" || txtEmail.Text == "E-mail" || txtPhone.Text == "Mobile Number" || txtCity.Text == "City" || txtCountry.Text == "Country" || txtCurrentPass.Text == "Current Password" || txtNewPass.Text == "New Password")
            {
                MessageBox.Show("Please fill in all the fields");
            }

            else
            {
                string fname = txtFName.Text;
                string lname = txtLName.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string city = txtCity.Text;
                string country = txtCountry.Text;
                string currentpass = txtCurrentPass.Text;
                string newpass = txtNewPass.Text;

                SqlConnection con = new SqlConnection(Global.ConnectionString);
                string qry = "Select Password from tblUser where Username='" + uName + "'";
                SqlDataAdapter sda = new SqlDataAdapter(qry, con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "tblUser");

                string pw = ds.Tables[0].Rows[0][0].ToString();

                if (pw.Trim()==currentpass.Trim())
                {
                    SqlConnection con1 = new SqlConnection(Global.ConnectionString);
                    string qry1 = "Update tblUser Set FName='" + fname + "', LName='" + lname + "', Email='" + email + "', Phone='" + phone + "', City='" + city + "', Country='" + country + "', Password='" + newpass + "' Where Username ='" + uName + "'";
                    SqlCommand cmd = new SqlCommand(qry1, con1);

                    try
                    {
                        con1.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account updated successfully");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Couldn't update your account, Error Generated: " + ex);
                    }

                    finally
                    {
                        txtFName.Text = "First Name";
                        txtFName.ForeColor = Color.Gray;

                        txtLName.Text = "Last Name";
                        txtLName.ForeColor = Color.Gray;

                        txtEmail.Text = "E-mail";
                        txtEmail.ForeColor = Color.Gray;

                        txtPhone.Text = "Mobile Number";
                        txtPhone.ForeColor = Color.Gray;

                        txtCity.Text = "City";
                        txtCity.ForeColor = Color.Gray;

                        txtCountry.Text = "Country";
                        txtCountry.ForeColor = Color.Gray;

                        txtCurrentPass.PasswordChar = '\0';
                        txtCurrentPass.Text = "Current Password";
                        txtCurrentPass.ForeColor = Color.Gray;

                        txtNewPass.PasswordChar = '\0';
                        txtNewPass.Text = "New Password";
                        txtNewPass.ForeColor = Color.Gray;

                        con.Close();

                        SqlConnection con2 = new SqlConnection(Global.ConnectionString);
                        string qry2 = "Select FName,LName,Email,Phone,City,Country from tblUser where Username='" + uName + "'";
                        SqlDataAdapter sda1 = new SqlDataAdapter(qry2, con2);
                        DataSet ds1 = new DataSet();
                        sda1.Fill(ds1, "tblUser");

                        string firstname = ds1.Tables[0].Rows[0][0].ToString();
                        string lastname = ds1.Tables[0].Rows[0][1].ToString();
                        string email2 = ds1.Tables[0].Rows[0][2].ToString();
                        string phone2 = ds1.Tables[0].Rows[0][3].ToString();
                        string city2 = ds1.Tables[0].Rows[0][4].ToString();
                        string country2 = ds1.Tables[0].Rows[0][5].ToString();

                        lblFLName.Text = (firstname.Trim() + " " + lastname.Trim());
                        lblUserEmail.Text = email2.Trim();
                        lblPNumber.Text = phone2.Trim();
                        lblCity.Text = city2.Trim();
                        lblCountry.Text = country2.Trim();
                    }
                }

                else
                {
                    MessageBox.Show("Please verify your current password");

                    txtCurrentPass.PasswordChar = '\0';
                    txtCurrentPass.Text = "Current Password";
                    txtCurrentPass.ForeColor = Color.Gray;

                    txtNewPass.PasswordChar = '\0';
                    txtNewPass.Text = "New Password";
                    txtNewPass.ForeColor = Color.Gray;
                }

            }
        }

        private void linkDelAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection con = new SqlConnection(Global.ConnectionString);
            string qry = "Delete from tblUser Where Username ='" + uName + "'";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account deleted successfully, Please log in");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Couldn't delete your account, Error Generated: " + ex);
            }

            finally
            {
                formLogin frmLogin = new formLogin();
                frmLogin.Show();
                this.Hide();
            }
        }
    }
}
