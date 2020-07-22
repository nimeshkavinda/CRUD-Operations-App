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
    }
}
