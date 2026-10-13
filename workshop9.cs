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
    public partial class workshop9 : Form
    {
        public workshop9()
        {
            InitializeComponent();
        }
        void showByCategory()
        {
            SqlConnection conn = DBConnect.northwindConnection();
            String sql = "Select Distinct(CategoryName) From Categories Order By CategoryName";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboCategory.DataSource = dt;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryName";
            conn.Close();
        }
        void showOrderByYear()
        {
            SqlConnection conn = DBConnect.northwindConnection();
            String sql = "SELECT DISTINCT YEAR(OrderDate) AS YearOrder FROM Orders WHERE OrderDate IS NOT NULL ORDER BY YearOrder";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboYear.DataSource = dt;
            cboYear.DisplayMember = "YearOrder";
            cboYear.ValueMember = "YearOrder";
            conn.Close();
        }

        void showEmployeeSaleVolume(String CategoryName, int year)
        {
            SqlConnection conn = DBConnect.northwindConnection();

            // ใช้วิธีเขียน SQL Command ตรงๆ ใน C# แทนการพึ่งพา Stored Procedure ของเดิม
            String sql = "spSaleVolumeByCategoryAndYear";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@categoryName", CategoryName);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvEmployeeVolume.DataSource = dt;

            if (dgvEmployeeVolume.Columns["saleVolume"] != null)
            {
                dgvEmployeeVolume.Columns["saleVolume"].DefaultCellStyle.Format = "0.00"; // หรือ "0.00"
                dgvEmployeeVolume.Columns["saleVolume"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            conn.Close();
        }

        //แสดงรายละเอียดรายการสินค้าที่ขาย
        void showSalVolumeDetail(int employeeID, String categoryName, int year)
        {
            SqlConnection conn = DBConnect.northwindConnection();
            String sql = "spSaleVolumeDetails";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@employeeID", employeeID);
            cmd.Parameters.AddWithValue("@categoryName", categoryName);
            cmd.Parameters.AddWithValue("@year", year);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvVolumeDetail.DataSource = dt;
            /*if (dgvVolumeDetail.Columns["saleVolume"] != null)
            {
                dgvVolumeDetail.Columns["saleVolume"].DefaultCellStyle.Format = "0.00"; // หรือ "0.00"
                dgvVolumeDetail.Columns["saleVolume"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }*/
            conn.Close();
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            String categoryName = cboCategory.SelectedValue.ToString();
            int year = Convert.ToInt32(cboYear.SelectedValue);

            showEmployeeSaleVolume(categoryName, year);

            int employeeID = Convert.ToInt32(dgvEmployeeVolume.Rows[0].Cells["EmployeeID"].Value);
            showSalVolumeDetail(employeeID, categoryName, year);
            dgvVolumeDetail.DataSource = null;
        }

        private void workshop9_Load(object sender, EventArgs e)
        {
            showByCategory();
            showOrderByYear();
        }

        private void dgvEmployeeVolume_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                DataGridViewRow row = dgvEmployeeVolume.Rows[e.RowIndex];
                
                    int employeeID = Convert.ToInt32(row.Cells["EmployeeID"].Value);
                    String categoryName = cboCategory.SelectedValue.ToString();
                    int year = Convert.ToInt32(cboYear.SelectedValue);

                    showSalVolumeDetail(employeeID, categoryName, year);
        }
    }
}
