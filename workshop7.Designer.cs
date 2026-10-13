namespace WinFormsApp1
{
    partial class workshop7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboSearch = new ComboBox();
            txtSearch = new TextBox();
            btnShow = new Button();
            dgvGridView = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGridView).BeginInit();
            SuspendLayout();
            // 
            // cboSearch
            // 
            cboSearch.BackColor = SystemColors.MenuBar;
            cboSearch.FormattingEnabled = true;
            cboSearch.Items.AddRange(new object[] { "รหัสลูกค้า", "ชื่อบริษัทลูกค้า", "ประเทศลูกค้า", "ลูกค้าทั้งหมด" });
            cboSearch.Location = new Point(235, 46);
            cboSearch.Name = "cboSearch";
            cboSearch.Size = new Size(256, 33);
            cboSearch.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(538, 48);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(285, 31);
            txtSearch.TabIndex = 1;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.LightSteelBlue;
            btnShow.Location = new Point(863, 41);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(142, 45);
            btnShow.TabIndex = 2;
            btnShow.Text = "แสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // dgvGridView
            // 
            dgvGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGridView.Location = new Point(64, 127);
            dgvGridView.Name = "dgvGridView";
            dgvGridView.RowHeadersWidth = 62;
            dgvGridView.Size = new Size(1006, 479);
            dgvGridView.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 51);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 4;
            label1.Text = "ค้นหาจาก:";
            // 
            // workshop7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 676);
            Controls.Add(label1);
            Controls.Add(dgvGridView);
            Controls.Add(btnShow);
            Controls.Add(txtSearch);
            Controls.Add(cboSearch);
            Name = "workshop7";
            Text = "workshop7";
            Load += workshop7_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSearch;
        private TextBox txtSearch;
        private Button btnShow;
        private DataGridView dgvGridView;
        private Label label1;
    }
}