using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFE_management.AllUserControls
{
    public partial class UC_PlaceOrder : UserControl
    {

        function fn = new function();
        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        private void ComboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = ComboCategory.Text;
            String query = "select name from items where category ='" + category + "'";
            showItemList(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String category = ComboCategory.Text;
            String query = "select name from items where category ='" + category + "' and name like '" + txtSearch.Text + "%'";
            showItemList(query);
        }

        private void showItemList(string query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getdata(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }
    }
}
