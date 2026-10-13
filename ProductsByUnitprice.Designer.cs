namespace WinFormsApp1
{
    partial class ProductsByUnitprice
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
            txtMinPrice = new TextBox();
            txtMaxPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbtnShow = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // dgvResult
            // 
            dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(102, 106);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 62;
            dgvResult.Size = new Size(1023, 479);
            dgvResult.TabIndex = 0;
            dgvResult.CellContentClick += dgvResult_CellContentClick;
            // 
            // txtMinPrice
            // 
            txtMinPrice.Location = new Point(224, 31);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Size = new Size(150, 31);
            txtMinPrice.TabIndex = 1;
            txtMinPrice.TextChanged += txtMinPrice_TextChanged;
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Location = new Point(533, 31);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.Size = new Size(150, 31);
            txtMaxPrice.TabIndex = 2;
            txtMaxPrice.TextChanged += txtMaxPrice_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 37);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 3;
            label1.Text = "ป้อนราคาสินค้า เริ่มต้น:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(494, 37);
            label2.Name = "label2";
            label2.Size = new Size(33, 25);
            label2.TabIndex = 4;
            label2.Text = "ถึง:";
            // 
            // tbtnShow
            // 
            tbtnShow.Location = new Point(764, 25);
            tbtnShow.Name = "tbtnShow";
            tbtnShow.Size = new Size(134, 43);
            tbtnShow.TabIndex = 5;
            tbtnShow.Text = "แสดงข้อมูล";
            tbtnShow.UseVisualStyleBackColor = true;
            tbtnShow.Click += tbtnShow_Click;
            // 
            // ProductsByUnitprice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 614);
            Controls.Add(tbtnShow);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMaxPrice);
            Controls.Add(txtMinPrice);
            Controls.Add(dgvResult);
            Name = "ProductsByUnitprice";
            Text = "ProductsByUnitprice";
            Load += ProductsByUnitprice_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResult;
        private TextBox txtMinPrice;
        private TextBox txtMaxPrice;
        private Label label1;
        private Label label2;
        private Button tbtnShow;
    }
}