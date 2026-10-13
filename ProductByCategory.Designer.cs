namespace WinFormsApp1
{
    partial class ProductByCategory
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
            label1 = new Label();
            cboCategory = new ComboBox();
            tbtnShow = new Button();
            dgvResult = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 35);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "ประเภทสินค้า:";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(260, 32);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(345, 33);
            cboCategory.TabIndex = 1;
            // 
            // tbtnShow
            // 
            tbtnShow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbtnShow.Location = new Point(726, 21);
            tbtnShow.Name = "tbtnShow";
            tbtnShow.Size = new Size(209, 53);
            tbtnShow.TabIndex = 2;
            tbtnShow.Text = "แสดงข้อมูล";
            tbtnShow.UseVisualStyleBackColor = true;
            tbtnShow.Click += tbtnShow_Click;
            // 
            // dgvResult
            // 
            dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(49, 102);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 62;
            dgvResult.Size = new Size(996, 478);
            dgvResult.TabIndex = 3;
            // 
            // ProductByCategory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 619);
            Controls.Add(dgvResult);
            Controls.Add(tbtnShow);
            Controls.Add(cboCategory);
            Controls.Add(label1);
            Name = "ProductByCategory";
            Text = "ProductByCategory";
            Load += ProductByCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboCategory;
        private Button tbtnShow;
        private DataGridView dgvResult;
    }
}