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
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            setPosition();
            lbMsg.Visible = false; // ซ่อนข้อความแจ้งเตือนผลการบันทึกเมื่อเปิดฟอร์ม
            txtPassword.UseSystemPasswordChar = true;
            txtCfPassword.UseSystemPasswordChar = true;
        }

        public int addNewUser()
        {
            SqlConnection conn = DBConnect.DBExampleConnection();

            SqlCommand cmd = new SqlCommand("AddUser_Transaction", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userID", txtEmail.Text);
            cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
            cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
            cmd.Parameters.AddWithValue("@position", cboPosition.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            SqlParameter result = new SqlParameter("@result", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            cmd.Parameters.Add(result);
            cmd.ExecuteNonQuery();
            conn.Close();

            return Convert.ToInt32(result.Value);
        }

        public void setPosition()
        {
            cboPosition.Items.Clear(); // ป้องกันค่าซ้ำ
            cboPosition.Items.Add("Manager");
            cboPosition.Items.Add("IT Developer");
            cboPosition.Items.Add("Project Manager");
            cboPosition.Items.Add("UX/UI Designer");
            cboPosition.Items.Add("Database Admin");
            cboPosition.SelectedIndex = 0;
        }

        public void clearForm()
        {
            txtEmail.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtPassword.Clear();
            txtCfPassword.Clear(); // เคลียร์ช่องยืนยันรหัสผ่าน
            cboPosition.SelectedIndex = 0;
        }

        public int checkInputForm()
        {
            int status = 0;

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lbEmailErr.Text = "ป้อนอีเมล์...";
                txtEmail.Focus();
                status = -1;
            }
            else
            {
                lbEmailErr.Text = "*";
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lbPwdErr.Text = "ป้อนรหัสผ่าน...";
                txtPassword.Focus();
                status = -1;
            }
            else
            {
                lbPwdErr.Text = "*";
            }

            if (!txtCfPassword.Text.Equals(txtPassword.Text))
            {
                lbCfPwdErr.Text = "ป้อนรหัสผ่านให้ตรงกัน...";
                txtCfPassword.Focus();
                status = -1;
            }
            else
            {
                lbCfPwdErr.Text = "*";
            }

            return status;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkInputForm() == -1) return;

            if (addNewUser() == 0)
            {
                lbEmailErr.Text = "Email ซ้ำ!! มีผู้ใช้ในระบบแล้ว";
                lbMsg.Visible = false;
                txtEmail.Focus();
                txtEmail.SelectAll();
            }
            else
            {
                lbMsg.Text = "เพิ่มข้อมูลผู้ใช้ในระบบแล้ว...";
                lbMsg.Visible = true;
                clearForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void cboPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}