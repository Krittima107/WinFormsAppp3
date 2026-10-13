namespace WinFormsApp1
{
    partial class OrdersAndDetail
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
            cboYear = new ComboBox();
            tbnShow = new Button();
            label2 = new Label();
            dgvOrders = new DataGridView();
            label3 = new Label();
            dgvOrderDetail = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 23);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "ปีที่สั่งซื้อ:";
            // 
            // cboYear
            // 
            cboYear.FormattingEnabled = true;
            cboYear.Location = new Point(247, 20);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(282, 33);
            cboYear.TabIndex = 1;
            // 
            // tbnShow
            // 
            tbnShow.Location = new Point(627, 12);
            tbnShow.Name = "tbnShow";
            tbnShow.Size = new Size(146, 48);
            tbnShow.TabIndex = 2;
            tbnShow.Text = "แสดงข้อมูล";
            tbnShow.UseVisualStyleBackColor = true;
            tbnShow.Click += tbnShow_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 68);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 3;
            label2.Text = "ใบสั่งซื้อ:";
            // 
            // dgvOrders
            // 
            dgvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(28, 96);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 62;
            dgvOrders.Size = new Size(856, 243);
            dgvOrders.TabIndex = 4;
            dgvOrders.CellContentClick += dgvOrders_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 342);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 5;
            label3.Text = "รายการสั่งซื้อ:";
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(28, 370);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowHeadersWidth = 62;
            dgvOrderDetail.Size = new Size(856, 136);
            dgvOrderDetail.TabIndex = 6;
            dgvOrderDetail.CellContentClick += dgvOrderDetail_CellContentClick;
            // 
            // OrdersAndDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 518);
            Controls.Add(dgvOrderDetail);
            Controls.Add(label3);
            Controls.Add(dgvOrders);
            Controls.Add(label2);
            Controls.Add(tbnShow);
            Controls.Add(cboYear);
            Controls.Add(label1);
            Name = "OrdersAndDetail";
            Text = "OrdersAndDetail";
            Load += OrdersAndDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboYear;
        private Button tbnShow;
        private Label label2;
        private DataGridView dgvOrders;
        private Label label3;
        private DataGridView dgvOrderDetail;
    }
}