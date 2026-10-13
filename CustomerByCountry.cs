using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class CustomerByCountry : Form
    {
        public CustomerByCountry()
        {
            InitializeComponent();
        }


        private void CustomerByCountry_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnect.northwindConnection();
            string sql = "Select Distinct Country From Customers Order by Country ASC";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow row = dt.NewRow();
            row[0] = "----- All country -----";
            dt.Rows.InsertAt(row, 0);

            cboCountry.DataSource = dt;
            cboCountry.ValueMember = "Country";
            cboCountry.DisplayMember = "Country";

            conn.Close();
        }

        private void showCustomerByCountry()
        {
            SqlConnection conn = DBConnect.northwindConnection();
            string sql = "Select * From Customers";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;
            conn.Close();
        }

        private void showCustomerByCountry(string countryName)
        {
            SqlConnection conn = DBConnect.northwindConnection();
            string sql = "Select * From Customers Where Country = @Country";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Country", countryName);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;
            conn.Close();
        }


        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void tbtnShow_Click(object sender, EventArgs e)
        {
            if (cboCountry.SelectedValue == null) return;

            string country = cboCountry.SelectedValue.ToString();

            if (country == "----- All country -----")
            {
                showCustomerByCountry();
            }
            else
            {
                showCustomerByCountry(country);
            }
        }
    }
}