namespace WinFormsApp1
{
    partial class CustomerByCountry
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
            dgvResult = new DataGridView();
            cboCountry = new ComboBox();
            tbtnShow = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // dgvResult
            // 
            dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(48, 141);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 62;
            dgvResult.Size = new Size(1014, 426);
            dgvResult.TabIndex = 0;
            dgvResult.CellContentClick += dgvResult_CellContentClick;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(275, 60);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(341, 33);
            cboCountry.TabIndex = 1;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            // 
            // tbtnShow
            // 
            tbtnShow.Location = new Point(696, 52);
            tbtnShow.Name = "tbtnShow";
            tbtnShow.Size = new Size(181, 46);
            tbtnShow.TabIndex = 2;
            tbtnShow.Text = "แสดงข้อมูล";
            tbtnShow.UseVisualStyleBackColor = true;
            tbtnShow.Click += tbtnShow_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 63);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 3;
            label1.Text = "เลือกประเทศ:";
            // 
            // CustomerByCountry
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 609);
            Controls.Add(label1);
            Controls.Add(tbtnShow);
            Controls.Add(cboCountry);
            Controls.Add(dgvResult);
            Name = "CustomerByCountry";
            Text = "CustomerByCountry";
            Load += CustomerByCountry_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResult;
        private ComboBox cboCountry;
        private Button tbtnShow;
        private Label label1;
    }
}