using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ProductByCategory : Form
    {
        public ProductByCategory()
        {
            InitializeComponent();
        }

        private void ProductByCategory_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnect.northwindConnection();

            String sql = "Select CategoryID, CategoryName From Categories Order By CategoryName ASC";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboCategory.DataSource = dt;
            cboCategory.ValueMember = "CategoryID";
            cboCategory.DisplayMember = "CategoryName";

            //เพิ่มรายการเลือกแบบทุกประเภท
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "All Category";
            dt.Rows.Add(row);

            conn.Close();

            cboCategory.SelectedIndex = cboCategory.Items.Count - 1;
            showProducts();
        }

        void showProducts()
        {
            SqlConnection conn = DBConnect.northwindConnection();

            String sql = "Select * From Products";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvResult.DataSource = dt;
            conn.Close();
        }
        void showProducts(int cid)
        {
            SqlConnection conn = DBConnect.northwindConnection();

            String sql = "Select * From Products Where CategoryID = @CategoryID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CategoryID", cid);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;
            conn.Close();
        }

        private void tbtnShow_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(cboCategory.SelectedValue);
            if(cid == 0)
            {
                showProducts();
            }
            else
            {
                showProducts(cid);
            }
        }
    }
}
