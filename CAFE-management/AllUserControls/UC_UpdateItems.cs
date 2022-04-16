﻿using System;
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
    public partial class UC_UpdateItems : UserControl
    {

        function fn = new function();
        String query;
        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {
            
            loadData();
        }
        public void loadData()
        {
            String query = "select * from items ";
            DataSet ds = fn.getdata(query);
            guna2DataGridView3.DataSource = ds.Tables[0];
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            String query = "select * from items where name like '" + txtSearchItem.Text + "%' ";
            DataSet ds = fn.getdata(query);
            guna2DataGridView3.DataSource=ds.Tables[0];
        }
        int id;
        private void guna2DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = guna2DataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = guna2DataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price =int.Parse(guna2DataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtCategory.Text = category;
            txtName.Text = name;
            txtPrice.Text = price.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String query = "update items set name='" +txtName.Text+"',category ='"+txtCategory.Text+ "',price ="+txtPrice.Text+" where id = " + id +"";
            fn.getdata(query);
            loadData();

            txtName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();

        }
    }
}
