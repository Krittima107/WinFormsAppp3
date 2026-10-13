namespace WinFormsApp1
{
    partial class workshop9
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
            cboCategory = new ComboBox();
            cboYear = new ComboBox();
            btnShow = new Button();
            label1 = new Label();
            label2 = new Label();
            dgvEmployeeVolume = new DataGridView();
            dgvVolumeDetail = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVolumeDetail).BeginInit();
            SuspendLayout();
            // 
            // cboCategory
            // 
            cboCategory.BackColor = SystemColors.MenuBar;
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "รหัสลูกค้า", "ชื่อบริษัทลูกค้า", "ประเทศลูกค้า", "ลูกค้าทั้งหมด" });
            cboCategory.Location = new Point(179, 42);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(256, 33);
            cboCategory.TabIndex = 1;
            // 
            // cboYear
            // 
            cboYear.BackColor = SystemColors.MenuBar;
            cboYear.FormattingEnabled = true;
            cboYear.Items.AddRange(new object[] { "รหัสลูกค้า", "ชื่อบริษัทลูกค้า", "ประเทศลูกค้า", "ลูกค้าทั้งหมด" });
            cboYear.Location = new Point(634, 42);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(210, 33);
            cboYear.TabIndex = 2;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.LightSteelBlue;
            btnShow.Location = new Point(898, 31);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(175, 53);
            btnShow.TabIndex = 3;
            btnShow.Text = "แสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 45);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 5;
            label1.Text = "ประเภทสินค้า:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(540, 45);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 6;
            label2.Text = "ปีที่ขาย:";
            // 
            // dgvEmployeeVolume
            // 
            dgvEmployeeVolume.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployeeVolume.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployeeVolume.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeVolume.Location = new Point(58, 101);
            dgvEmployeeVolume.Name = "dgvEmployeeVolume";
            dgvEmployeeVolume.RowHeadersWidth = 62;
            dgvEmployeeVolume.Size = new Size(1006, 331);
            dgvEmployeeVolume.TabIndex = 7;
            dgvEmployeeVolume.CellMouseClick += dgvEmployeeVolume_CellMouseClick;
            // 
            // dgvVolumeDetail
            // 
            dgvVolumeDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVolumeDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVolumeDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVolumeDetail.Location = new Point(58, 477);
            dgvVolumeDetail.Name = "dgvVolumeDetail";
            dgvVolumeDetail.RowHeadersWidth = 62;
            dgvVolumeDetail.Size = new Size(1006, 283);
            dgvVolumeDetail.TabIndex = 8;
            // 
            // workshop9
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 782);
            Controls.Add(dgvVolumeDetail);
            Controls.Add(dgvEmployeeVolume);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnShow);
            Controls.Add(cboYear);
            Controls.Add(cboCategory);
            Name = "workshop9";
            Text = "workshop9";
            Load += workshop9_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVolumeDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCategory;
        private ComboBox cboYear;
        private Button btnShow;
        private Label label1;
        private Label label2;
        private DataGridView dgvEmployeeVolume;
        private DataGridView dgvVolumeDetail;
    }
}