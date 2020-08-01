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
    public partial class formHome : Form
    {
        string uName;
        string chkindate;
        string chkoutdate;
        string path;

        public void hidePanels()
        {
            pnlWelcome.Visible = false;
            pnlContact.Visible = false;
            pnlBook.Visible = false;
        }

        public formHome(string username)
        {
            InitializeComponent();
            lblUser.Text = username;
            uName = username;

            dtChkIn.Value = DateTime.Today;
            dtChkOut.Value = DateTime.Today;
            dtChkIn.MinDate = DateTime.Today;
            dtChkOut.MinDate = DateTime.Today;
            chkindate = dtChkIn.Value.ToString("yyyy/MM/dd");
            chkoutdate = dtChkIn.Value.ToString("yyyy/MM/dd");

            Encap ec = new Encap();
            ec.setPath(uName);
            path = ec.getPath();
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

        private void linkQuit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkRegUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formSignUp frmSignUp = new formSignUp();
            frmSignUp.Show();
            this.Hide();
        }

        string chkin;
        string chkout;

        private void btnFindRoom_Click(object sender, EventArgs e)
        {
            chkin = dtChkIn.Value.ToString("yyyy/MM/dd");
            chkout = dtChkOut.Value.ToString("yyyy/MM/dd");

            if (chkin == chkindate || chkout == chkoutdate)
            {
                MessageBox.Show("Please select Check-In and Check-Out dates.\nAlso note that you can't check-in for today. Please pick a date from tomorrow onwards to check-in");
            }
            else
            {
                if (slctRoomType.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the room type");
                }

                else
                {
                    try
                    {
                        int roomid = slctRoomType.SelectedIndex;
                        
                        SqlConnection con = new SqlConnection(Global.ConnectionString);
                        string qry = "Select * from tblRoom where RoomType='"+roomid+"' and Customer IS NULL";
                        SqlDataAdapter sda = new SqlDataAdapter(qry, con);
                        DataTable dtbl = new DataTable();
                        sda.Fill(dtbl);

                        if (!(dtbl.Rows.Count == 0))
                        {
                            hidePanels();
                            pnlBook.Visible = true;
                        }

                        else
                        {
                            MessageBox.Show("There are no available rooms");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error generated: "+ex);
                    }

                    finally
                    {
                        dtChkIn.Value = DateTime.Today;
                        dtChkOut.Value = DateTime.Today;
                        slctRoomType.Text = "Please select room";
                    }

                }
            }
        }

        private void pnlBook_Paint(object sender, PaintEventArgs e)
        {
            if (slctRoomType.SelectedIndex == 0)
            {
                pnlroomS1.Visible = true;
                pnlroomS2.Visible = true;
                pnlroomC1.Visible = false;
                pnlroomC2.Visible = false;
                pnlroomF1.Visible = false;
                pnlroomF2.Visible = false;
            }

            if (slctRoomType.SelectedIndex == 1)
            {
                pnlroomS1.Visible = false;
                pnlroomS2.Visible = false;
                pnlroomC1.Visible = true;
                pnlroomC2.Visible = true;
                pnlroomF1.Visible = false;
                pnlroomF2.Visible = false;
            }

            if (slctRoomType.SelectedIndex == 2)
            {
                pnlroomS1.Visible = false;
                pnlroomS2.Visible = false;
                pnlroomC1.Visible = false;
                pnlroomC2.Visible = false;
                pnlroomF1.Visible = true;
                pnlroomF2.Visible = true;
            }
        }

        private void btnReserveS1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Global.ConnectionString);
            string qry = "Update tblRoom Set CheckIn='" + chkin + "', CheckOut='" + chkout + "', Customer='" + uName + "' Where RoomID = 1";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Room has been reserved for " + uName + "\nCheck-In " + chkin + " Check-Out " + chkout + "");

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("==============Seaside South Park=============");
                        sw.WriteLine("===========Room Reservation Ticket===========");
                        sw.WriteLine("");
                        sw.WriteLine("Customer Account: " + uName);
                        sw.WriteLine("Room Number: 1");
                        sw.WriteLine("Room Type: Solo");
                        sw.WriteLine("Check-In " + chkin);
                        sw.WriteLine("Check-Out: " + chkout);
                        sw.WriteLine("");
                        sw.WriteLine("==========Thank you for choosing us==========");
                        sw.WriteLine("=======We hope you enjoy your vacation=======");
                    }

                    MessageBox.Show("Please find the ticket in your documents");
                }

                else
                {
                    MessageBox.Show("Ticket won't be printed.\nA ticket for " +uName+ " already exists in the local drive");
                }   
            }

            catch (Exception ex)
            {
                MessageBox.Show("Couldn't reserve the room, Error Generated: " + ex);
            }

            finally
            {
                hidePanels();
                pnlWelcome.Visible = true;
            }
        }

        private void btnReserveS2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Global.ConnectionString);
            string qry = "Update tblRoom Set CheckIn='" + chkin + "', CheckOut='" + chkout + "', Customer='" + uName + "' Where RoomID = 2";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Room has been reserved for " + uName + "\nCheck-In " + chkin + " Check-Out " + chkout + "");

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("==============Seaside South Park=============");
                        sw.WriteLine("===========Room Reservation Ticket===========");
                        sw.WriteLine("");
                        sw.WriteLine("Customer Account: " + uName);
                        sw.WriteLine("Room Number: 2");
                        sw.WriteLine("Room Type: Solo");
                        sw.WriteLine("Check-In " + chkin);
                        sw.WriteLine("Check-Out: " + chkout);
                        sw.WriteLine("");
                        sw.WriteLine("==========Thank you for choosing us==========");
                        sw.WriteLine("=======We hope you enjoy your vacation=======");
                    }

                    MessageBox.Show("Please find the ticket in your documents");
                }

                else
                {
                    MessageBox.Show("Ticket won't be printed.\nA ticket for " + uName + " already exists in the local drive");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Couldn't reserve the room, Error Generated: " + ex);
            }

            finally
            {
                hidePanels();
                pnlWelcome.Visible = true;
            }
        }

        private void btnReserveC1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Global.ConnectionString);
            string qry = "Update tblRoom Set CheckIn='" + chkin + "', CheckOut='" + chkout + "', Customer='" + uName + "' Where RoomID = 3";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Room has been reserved for " + uName + "\nCheck-In " + chkin + " Check-Out " + chkout + "");

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("==============Seaside South Park=============");
                        sw.WriteLine("===========Room Reservation Ticket===========");
                        sw.WriteLine("");
                        sw.WriteLine("Customer Account: " + uName);
                        sw.WriteLine("Room Number: 3");
                        sw.WriteLine("Room Type: Couple");
                        sw.WriteLine("Check-In " + chkin);
                        sw.WriteLine("Check-Out: " + chkout);
                        sw.WriteLine("");
                        sw.WriteLine("==========Thank you for choosing us==========");
                        sw.WriteLine("=======We hope you enjoy your vacation=======");
                    }

                    MessageBox.Show("Please find the ticket in your documents");
                }

                else
                {
                    MessageBox.Show("Ticket won't be printed.\nA ticket for " + uName + " already exists in the local drive");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Couldn't reserve the room, Error Generated: " + ex);
            }

            finally
            {
                hidePanels();
                pnlWelcome.Visible = true;
            }
        }

        private void btnReserveC2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Global.ConnectionString);
            string qry = "Update tblRoom Set CheckIn='" + chkin + "', CheckOut='" + chkout + "', Customer='" + uName + "' Where RoomID = 4";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Room has been reserved for " + uName + "\nCheck-In " + chkin + " Check-Out " + chkout + "");

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("==============Seaside South Park=============");
                        sw.WriteLine("===========Room Reservation Ticket===========");
                        sw.WriteLine("");
                        sw.WriteLine("Customer Account: " + uName);
                        sw.WriteLine("Room Number: 4");
                        sw.WriteLine("Room Type: Couple");
                        sw.WriteLine("Check-In " + chkin);
                        sw.WriteLine("Check-Out: " + chkout);
                        sw.WriteLine("");
                        sw.WriteLine("==========Thank you for choosing us==========");
                        sw.WriteLine("=======We hope you enjoy your vacation=======");
                    }

                    MessageBox.Show("Please find the ticket in your documents");
                }

                else
                {
                    MessageBox.Show("Ticket won't be printed.\nA ticket for " + uName + " already exists in the local drive");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Couldn't reserve the room, Error Generated: " + ex);
            }

            finally
            {
                hidePanels();
                pnlWelcome.Visible = true;
            }
        }

        private void btnReserveF1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Global.ConnectionString);
            string qry = "Update tblRoom Set CheckIn='" + chkin + "', CheckOut='" + chkout + "', Customer='" + uName + "' Where RoomID = 5";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Room has been reserved for " + uName + "\nCheck-In " + chkin + " Check-Out " + chkout + "");

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("==============Seaside South Park=============");
                        sw.WriteLine("===========Room Reservation Ticket===========");
                        sw.WriteLine("");
                        sw.WriteLine("Customer Account: " + uName);
                        sw.WriteLine("Room Number: 5");
                        sw.WriteLine("Room Type: Family");
                        sw.WriteLine("Check-In " + chkin);
                        sw.WriteLine("Check-Out: " + chkout);
                        sw.WriteLine("");
                        sw.WriteLine("==========Thank you for choosing us==========");
                        sw.WriteLine("=======We hope you enjoy your vacation=======");
                    }

                    MessageBox.Show("Please find the ticket in your documents");
                }

                else
                {
                    MessageBox.Show("Ticket won't be printed.\nA ticket for " + uName + " already exists in the local drive");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Couldn't reserve the room, Error Generated: " + ex);
            }

            finally
            {
                hidePanels();
                pnlWelcome.Visible = true;
            }
        }

        private void btnReserveF2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Global.ConnectionString);
            string qry = "Update tblRoom Set CheckIn='" + chkin + "', CheckOut='" + chkout + "', Customer='" + uName + "' Where RoomID = 6";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Room has been reserved for " + uName + "\nCheck-In " + chkin + " Check-Out " + chkout + "");

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("==============Seaside South Park=============");
                        sw.WriteLine("===========Room Reservation Ticket===========");
                        sw.WriteLine("");
                        sw.WriteLine("Customer Account: " + uName);
                        sw.WriteLine("Room Number: 6");
                        sw.WriteLine("Room Type: Family");
                        sw.WriteLine("Check-In " + chkin);
                        sw.WriteLine("Check-Out: " + chkout);
                        sw.WriteLine("");
                        sw.WriteLine("==========Thank you for choosing us==========");
                        sw.WriteLine("=======We hope you enjoy your vacation=======");
                    }

                    MessageBox.Show("Please find the ticket in your documents");
                }

                else
                {
                    MessageBox.Show("Ticket won't be printed.\nA ticket for " + uName + " already exists in the local drive");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Couldn't reserve the room, Error Generated: " + ex);
            }

            finally
            {
                hidePanels();
                pnlWelcome.Visible = true;
            }
        }
    }
}
