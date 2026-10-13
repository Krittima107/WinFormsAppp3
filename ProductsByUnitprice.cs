using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Linq;


namespace WinFormsApp1
{
    public partial class ProductsByUnitprice : Form
    {
        public ProductsByUnitprice()
        {
            InitializeComponent();
        }
        void showproducts()
        {
                SqlConnection con = DBConnect.northwindConnection();
                String sql = "SELECT * FROM Products";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvResult.DataSource = dt;
                con.Close();
            
        }

        private void ProductsByUnitprice_Load(object sender, EventArgs e)
        {
            showproducts();
        }

        private void tbtnShow_Click(object sender, EventArgs e)
        {

            decimal minPrice, maxPrice;

            if (!decimal.TryParse(txtMinPrice.Text, out minPrice) ||
                !decimal.TryParse(txtMaxPrice.Text, out maxPrice))
            {
                MessageBox.Show("กรุณากรอกราคาให้ถูกต้อง");
                return;
            }

            SqlConnection con = DBConnect.northwindConnection();

            string sql = "SELECT * FROM Products WHERE UnitPrice BETWEEN @MinPrice AND @MaxPrice";

            SqlDataAdapter da = new SqlDataAdapter(sql, con);

            da.SelectCommand.Parameters.AddWithValue("@MinPrice", minPrice);
            da.SelectCommand.Parameters.AddWithValue("@MaxPrice", maxPrice);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;

            con.Close();


        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtMinPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaxPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
