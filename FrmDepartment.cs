using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class FrmDepartment : Form
    {

        string dept_id = "";
        string action = "";

        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            ShowAllDepartment();

        }

        private void ShowAllDepartment()
        {
            SqlConnection conn = DBConnect.Company_DB_Connect();
            string sql = "Select * From Department Order By dept_id"; // เพิ่ม * ที่ขาดหายไปในใบงาน
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDepartment.DataSource = dt;
            conn.Close();

            //----format dgvDepartment---
            //แสดง-ซ่อนคอลัมน์
            dgvDepartment.Columns[0].Visible = true;
            dgvDepartment.Columns[1].Visible = true;
            dgvDepartment.Columns[2].Visible = false;
            dgvDepartment.Columns[3].Visible = false;
            dgvDepartment.Columns[4].Visible = false;

            //กำหนดข้อความบนส่วนหัวตาราง
            dgvDepartment.Columns[0].HeaderText = "รหัสแผนก";
            dgvDepartment.Columns[1].HeaderText = "ชื่อแผนก";

            //กำหนดคามกว้างคอลัมน์
            dgvDepartment.Columns[0].Width = 100;
            dgvDepartment.Columns[1].Width = 220;

            //กำหนดสีพื้นหลังแบบสลับ
            dgvDepartment.RowsDefaultCellStyle.BackColor = Color.Beige;
            dgvDepartment.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            //กำหนดฟอนต์
            dgvDepartment.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
            dgvDepartment.DefaultCellStyle.Font = new Font("Tahoma", 11);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //กำหนดค่าให้ตัวแปร
            dept_id = "";
            action = "insert";

            //เคลียร์ TextBox ให้ว่าง
            txtID.Clear();
            txtName.Clear();
            txtDesc.Clear();
            txtPhone.Clear();
            txtFax.Clear();
            txtID.Focus();
        }


        private void DeleteRecord()
        {
            SqlTransaction tr;
            SqlConnection conn = DBConnect.Company_DB_Connect();
            tr = conn.BeginTransaction();

            try
            {
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.Transaction = tr;
                com.CommandText = "Delete From Department Where dept_id = @id";
                com.Parameters.AddWithValue("@id", dept_id);
                com.ExecuteNonQuery();
                tr.Commit();
                ShowAllDepartment();

                //เคลียร์ค่าต่างๆ
                dept_id = "";
                txtID.Clear();
                txtName.Clear();
                txtDesc.Clear();
                txtPhone.Clear();
                txtFax.Clear();
                txtID.Focus();
            }
            catch
            {
                MessageBox.Show("เกิดข้อมูลผิดพลาดในการลบข้อมูล", "แจ้งข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tr.Rollback();
            }
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dept_id == "")
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบข้อมูล");
                return;
            }
            if (MessageBox.Show("คุณต้องการลบข้อมูลแผนก รหัส : " + dept_id + " ใช่หรือไม่", "ยืนยันการทำงาน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteRecord();
            }
        }

        private void InsertRecord()
        {
            SqlConnection conn = DBConnect.Company_DB_Connect();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "Insert_Department";

            com.Parameters.AddWithValue("@id", txtID.Text);
            com.Parameters.AddWithValue("@name", txtName.Text);
            com.Parameters.AddWithValue("@desc", txtDesc.Text);
            com.Parameters.AddWithValue("@phone", txtPhone.Text);
            com.Parameters.AddWithValue("@fax", txtFax.Text);

            com.Parameters.Add("@returnVal", SqlDbType.Int);
            com.Parameters["@returnVal"].Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            conn.Close();

            int result = (int)com.Parameters["@returnVal"].Value;
            if (result == -1)
            {
                MessageBox.Show("รหัสแผนกซ้ำ");
                txtID.Focus();
                txtID.SelectAll();
                return;
            }
            else if (result == 0)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการเพิ่มข้อมูล");
                return;
            }
            else
            {
                ShowAllDepartment();
            }
        }

        private void Update_Record()
        {
            SqlConnection conn = DBConnect.Company_DB_Connect();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "Update_Department";

            com.Parameters.AddWithValue("@curr_id", dept_id);
            com.Parameters.AddWithValue("@id", txtID.Text);
            com.Parameters.AddWithValue("@name", txtName.Text);
            com.Parameters.AddWithValue("@desc", txtDesc.Text);
            com.Parameters.AddWithValue("@phone", txtPhone.Text);
            com.Parameters.AddWithValue("@fax", txtFax.Text);

            com.Parameters.Add("@returnVal", SqlDbType.Int);
            com.Parameters["@returnVal"].Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            conn.Close();

            int result = (int)com.Parameters["@returnVal"].Value;
            if (result == -1)
            {
                MessageBox.Show("รหัสแผนกซ้ำ");
                txtID.Focus();
                txtID.SelectAll();
                return;
            }
            else if (result == 0)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการปรับปรุงข้อมูล");
                return;
            }
            else
            {
                ShowAllDepartment();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่า action ไม่ว่างเปล่า และช่องรหัสแผนกไม่ได้ถูกปล่อยว่าง
            if (action != "" && txtID.Text.Trim() == "")
            {
                MessageBox.Show("กรุณากรอกรหัสแผนก");
                txtID.Focus();
                return;
            }

            if (action == "insert")
            {
                InsertRecord();
            }
            else if (action == "update")
            {
                Update_Record();
            }
        }

        private void dgvDepartment_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // ป้องกัน Error หากผู้ใช้คลิกโดนส่วนหัวตาราง
            if (e.RowIndex < 0) return;

            int row = e.RowIndex;
            dept_id = dgvDepartment.Rows[row].Cells[0].Value.ToString();
            action = "update";

            //แสดงข้อมูลใน TextBox
            txtID.Text = dgvDepartment.Rows[row].Cells[0].Value.ToString();
            txtName.Text = dgvDepartment.Rows[row].Cells[1].Value.ToString();
            txtDesc.Text = dgvDepartment.Rows[row].Cells[2].Value.ToString();
            txtPhone.Text = dgvDepartment.Rows[row].Cells[3].Value.ToString();
            txtFax.Text = dgvDepartment.Rows[row].Cells[4].Value.ToString();
        }
    }
}
