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

namespace SeasideSouthPark
{
    public partial class formAccount : Form
    {
        string uName;

        public formAccount(string username)
        {
            uName = username;
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

            picboxUser.Image.Save(stream,System.Drawing.Imaging.ImageFormat.Png);

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

            dp.Fill(ds,"Images");
            DataRow myRow;
            myRow = ds.Tables["Images"].Rows[0];

            MyData = (byte[])myRow["ProImg"];

            MemoryStream stream1 = new MemoryStream(MyData);

            picboxUser.Image = Image.FromStream(stream);
        }
    }
}
