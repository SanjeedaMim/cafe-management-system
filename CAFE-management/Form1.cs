using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFE_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard ds = new Dashboard("Guest");
            ds.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (txtUsername.Text == "Minifa" && txtPassword.Text =="031720")
            //{
            //    Dashboard ds = new Dashboard();
            //    ds.Show();
            //    this.Hide();
            //}

            Dashboard ds = new Dashboard();
            ds.Show();
            this.Hide();
        }
    }
}
