using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class workshop7 : Form
    {
        public workshop7()
        {
            InitializeComponent();
        }

        void showAllcustomersOrder()
        {
            SqlConnection conn = DBConnect.northwindConnection();
            String sql = "Select * From CustomerOrderReport";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvGridView.DataSource = dt;
            conn.Close();
        }

        void showCustomerOrderByID(string id)
        {
            SqlConnection conn = DBConnect.northwindConnection();
            String sql = "Select * From CustomerOrderReport Where CustomerID = @customerID";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@customerID",  id );

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvGridView.DataSource = dt;
            conn.Close();

        }

        private void workshop7_Load(object sender, EventArgs e)
        {
            cboSearch.SelectedIndex = 3;
            showAllcustomersOrder();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            String keyword = txtSearch.Text.Trim();
            if (cboSearch.SelectedIndex == 0)
            {
                showCustomerOrderByID(keyword);
            }
            else if (cboSearch.SelectedIndex == 1)
            {
                showCustomerOrderByCompanyName(keyword);
            }
            else if (cboSearch.SelectedIndex == 2)
            {
                showCustomerOrderByCountry(keyword);
            }
            else
            {
                showAllcustomersOrder();
            }
        }
        void showCustomerOrderByCompanyName(string CompanyName)
        {
            SqlConnection conn = DBConnect.northwindConnection();
            String sql = "Select * From CustomerOrderReport Where CompanyName Like @companyname";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@companyname", "%" + CompanyName + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvGridView.DataSource = dt;
            conn.Close();
        }
        void showCustomerOrderByCountry(string country)
        {
            SqlConnection conn = DBConnect.northwindConnection();
            String sql = "Select * From CustomerOrderReport Where Country Like @country";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@country", "%" + country + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvGridView.DataSource = dt;
            conn.Close();
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSearch.SelectedIndex == 3)
            {
                txtSearch.Clear();
            }
            else
            {
                txtSearch.Focus();
            }
        }

        
    }
}
