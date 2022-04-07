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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(String user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                btnAddItems.Hide();
                btnUpdate.Hide();
                btnRemove.Hide();
            }
            else if (user =="Admin")
            {
                btnAddItems.Show();
                btnUpdate.Show();
                btnRemove.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }
    }
}
