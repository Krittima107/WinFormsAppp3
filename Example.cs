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
    public partial class Example : Form
    {
        public Example()
        {
            InitializeComponent();
        }

        DataTable getData(String sql)
        {
            SqlConnection conn = DBConnect.northwindConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        DataTable getDataSP(String spName, params SqlParameter[] p)
        {
            SqlConnection conn = DBConnect.northwindConnection();
            SqlCommand cmd = new SqlCommand(spName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(p);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Example_Load(object sender, EventArgs e)
        {
            cbo1.DataSource = getData("Select CategoryID, CategoryName From Categories Order By CategoryName");
            cbo1.DisplayMember = "CategoryName";
            cbo1.ValueMember = "CategoryID";

            cbo2.DataSource = getData("Select ShipperID, CompanyName From Shippers Order By CompanyName");
            cbo2.DisplayMember = "CompanyName";
            cbo2.ValueMember = "ShipperID";

            dgv1.AllowUserToAddRows = false;
            dgv2.AllowUserToAddRows = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // เช็กว่าเลือกครบหรือยัง
            if (cbo1.SelectedValue == null || cbo2.SelectedValue == null)
            {
                MessageBox.Show("กรุณาเลือกประเภทสินค้าและบริษัทผู้จัดส่ง");
                return;
            }

            int categoryID = Convert.ToInt32(cbo1.SelectedValue);
            int shipperID = Convert.ToInt32(cbo2.SelectedValue);

            // เรียก SP แล้วแสดงใน dgv1
            dgv1.DataSource = getDataSP("sp_GetSalesByShippedYear",
                new SqlParameter("@CategoryID", categoryID),
                new SqlParameter("@ShipperID", shipperID));

            // ล้างตารางล่างทุกครั้งที่กดแสดงข้อมูลใหม่
            dgv2.DataSource = null;

            // จัดรูปแบบตัวเลข
            dgv1.Columns["TotalQuantity"].DefaultCellStyle.Format = "N0";
            dgv1.Columns["TotalVolume"].DefaultCellStyle.Format = "N2";
            dgv1.Columns["TotalQuantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv1.Columns["TotalVolume"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // คลิกที่หัวตารางให้ข้ามไป
            if (e.RowIndex < 0) return;

            int categoryID = Convert.ToInt32(cbo1.SelectedValue);
            int shipperID = Convert.ToInt32(cbo2.SelectedValue);
            int year = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells["ShippedYear"].Value);

            // เรียก SP แล้วแสดงใน dgv2
            dgv2.DataSource = getDataSP("sp_GetProductSalesByYear",
                new SqlParameter("@CategoryID", categoryID),
                new SqlParameter("@ShipperID", shipperID),
                new SqlParameter("@ShippedYear", year));

            // จัดรูปแบบตัวเลข
            dgv2.Columns["Total_Quantity"].DefaultCellStyle.Format = "N0";
            dgv2.Columns["Total_Sale_Volumes"].DefaultCellStyle.Format = "N2";
            dgv2.Columns["Total_Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv2.Columns["Total_Sale_Volumes"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
