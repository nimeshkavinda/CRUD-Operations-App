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

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\GitHub\CRUD-Operations-App\SeasideSouthPark\SeasideDB.mdf;Integrated Security=True;Connect Timeout=30");
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

        private void linkImgUpload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "png files (*.png)|*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,

                    // and assign that to the picboxUser.Image property

                    picboxUser.Image = new Bitmap(dlg.FileName);
                }
            }

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\GitHub\CRUD-Operations-App\SeasideSouthPark\SeasideDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("Update tblUser set ProImg(@Pic) where Username='" + uName + "'", con);
            MemoryStream stream = new MemoryStream();

            picboxUser.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);

            byte[] pic = stream.ToArray();

            cmd.Parameters.AddWithValue("@Pic", pic);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\GitHub\CRUD-Operations-App\SeasideSouthPark\SeasideDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command = new SqlCommand("Select ProImg from tblUser where Username='" + uName + "'", connect);

            SqlDataAdapter dp = new SqlDataAdapter(command);
            DataSet ds = new DataSet("Images");

            //DataTable table = new DataTable();

            //dp.Fill(table);

            //byte[] img = (byte[])table.Rows[0][3];

            //MemoryStream ms = new MemoryStream(img);

            //picboxUser.Image = Image.FromStream(ms);

            //dp.Dispose();

            byte[] MyData = new byte[0];

            dp.Fill(ds, "Images");
            DataRow myRow;
            myRow = ds.Tables["Images"].Rows[0];

            MyData = (byte[])myRow["ProImg"];

            MemoryStream stream1 = new MemoryStream(MyData);

            picboxUser.Image = Image.FromStream(stream);
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

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\GitHub\CRUD-Operations-App\SeasideSouthPark\SeasideDB.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "Update tblUser Set FName='"+fname+ "', LName='" + lname + "', Email='" + email + "', Phone='" + phone + "', City='" + city + "', Country='" + country + "', Password='" + newpass + "' Where Username ='" + uName + "'";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
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

                    txtCurrentPass.Text = "Current Password";
                    txtCurrentPass.ForeColor = Color.Gray;

                    txtNewPass.Text = "New Password";
                    txtNewPass.ForeColor = Color.Gray;

                    SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\GitHub\CRUD-Operations-App\SeasideSouthPark\SeasideDB.mdf;Integrated Security=True;Connect Timeout=30");
                    string qry2 = "Select FName,LName,Email,Phone,City,Country from tblUser where Username='" + uName + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(qry2, con2);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "tblUser");

                    string firstname = ds.Tables[0].Rows[0][0].ToString();
                    string lastname = ds.Tables[0].Rows[0][1].ToString();
                    string email2 = ds.Tables[0].Rows[0][2].ToString();
                    string phone2 = ds.Tables[0].Rows[0][3].ToString();
                    string city2 = ds.Tables[0].Rows[0][4].ToString();
                    string country2 = ds.Tables[0].Rows[0][5].ToString();

                    lblFLName.Text = (firstname.Trim() + " " + lastname.Trim());
                    lblUserEmail.Text = email2.Trim();
                    lblPNumber.Text = phone2.Trim();
                    lblCity.Text = city2.Trim();
                    lblCountry.Text = country2.Trim();
                }
            }
        }
    }
}
