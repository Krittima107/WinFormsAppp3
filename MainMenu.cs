using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void workshop3_Click(object sender, EventArgs e)
        {
            ProductsByUnitprice frm = new ProductsByUnitprice();
            frm.MdiParent = this;
            frm.Show();
        }

        private void workshop4_Click(object sender, EventArgs e)
        {
            CustomerByCountry frm = new CustomerByCountry();
            frm.MdiParent = this;
            frm.Show();
        }

        private void workshop5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductByCategory frm = new ProductByCategory();
            frm.MdiParent = this;
            frm.Show();
        }

        private void workshop6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersAndDetail frm = new OrdersAndDetail();
            frm.MdiParent = this;
            frm.Show();
        }

        private void workshop7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workshop7 frm = new workshop7();
            frm.MdiParent = this;
            frm.Show();
        }

        private void workshop8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestStoreProcedure frm = new TestStoreProcedure();
            frm.MdiParent = this;
            frm.Show();
        }

        private void workshop9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workshop9 frm = new workshop9();
            frm.MdiParent = this;
            frm.Show();
        }

        private void transactionLab1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUser frm = new FrmAddUser();
            frm.MdiParent = this;
            frm.Show();
        }

        private void transactionLab2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartment frm = new FrmDepartment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Example frm = new Example();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
