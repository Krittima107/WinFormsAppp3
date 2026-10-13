using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class OrdersAndDetail : Form
    {
        public OrdersAndDetail()
        {
            InitializeComponent();
        }

        private void OrdersAndDetail_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnect.northwindConnection();

            String sql = "Select Distinct(Year(OrderDate)) as YearOrder From Orders Order By YearOrder";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboYear.DataSource = dt;
            cboYear.DisplayMember = "YearOrder";
            cboYear.ValueMember = "YearOrder";

            conn.Close();
        }

        void showOrderByYear(String year)
        {
            SqlConnection conn = DBConnect.northwindConnection();

            String sql = "Select * From Orders Where Year(OrderDate) = @year";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@year", year);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvOrders.DataSource = dt;
            conn.Close();
            { }
        }

        private void tbnShow_Click(object sender, EventArgs e)
        {
            string year = cboYear.Text;
            showOrderByYear(year);
        }
        void showOrderDetail(int oederID)
        {
            SqlConnection conn = DBConnect.northwindConnection();

            String sql = "Select OD.ProductID, ProductName, CategoryName, OD.UnitPrice, Quantity, " +
            "(OD.UnitPrice * Quantity) As SumPrice, discount, (OD.UnitPrice * Quantity * discount) As DiscountPrice, " +
            "((OD.UnitPrice * Quantity)- (OD.UnitPrice * Quantity * discount)) As NetPrice " +
            "From [Order Details] As OD inner join Products As P ON OD.ProductID = P.ProductID " +
            "inner join Categories As C ON P.CategoryID = C.CategoryID Where OrderID = @orderID";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@orderID", oederID);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvOrderDetail.DataSource = dt;
            conn.Close();

        }

        private void dgvOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int orderID = Convert.ToInt32(dgvOrders.Rows[row].Cells[0].Value);
            showOrderDetail(orderID);
        }
    }
}
