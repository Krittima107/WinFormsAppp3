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
    public partial class Form2 : Form
    {
        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
        {
            showproducts();
        }
    }
}
