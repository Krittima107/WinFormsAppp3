namespace WinFormsApp1
{
    partial class Example
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
            cbo1 = new ComboBox();
            cbo2 = new ComboBox();
            dgv1 = new DataGridView();
            dgv2 = new DataGridView();
            btn1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            SuspendLayout();
            // 
            // cbo1
            // 
            cbo1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo1.FormattingEnabled = true;
            cbo1.Location = new Point(179, 45);
            cbo1.Name = "cbo1";
            cbo1.Size = new Size(289, 33);
            cbo1.TabIndex = 0;
            // 
            // cbo2
            // 
            cbo2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo2.FormattingEnabled = true;
            cbo2.Location = new Point(652, 45);
            cbo2.Name = "cbo2";
            cbo2.Size = new Size(240, 33);
            cbo2.TabIndex = 1;
            // 
            // dgv1
            // 
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(23, 126);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 62;
            dgv1.Size = new Size(1028, 184);
            dgv1.TabIndex = 2;
            dgv1.CellClick += dgv1_CellClick;
            // 
            // dgv2
            // 
            dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv2.Location = new Point(23, 361);
            dgv2.Name = "dgv2";
            dgv2.RowHeadersWidth = 62;
            dgv2.Size = new Size(1028, 235);
            dgv2.TabIndex = 3;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ActiveCaption;
            btn1.Location = new Point(920, 37);
            btn1.Name = "btn1";
            btn1.Size = new Size(131, 47);
            btn1.TabIndex = 4;
            btn1.Text = "แสดงข้อมูล";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 48);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 5;
            label1.Text = "เลือกประเภทสินค้า : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(533, 48);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 6;
            label2.Text = "บริษัทผู้จัดส่ง : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 98);
            label3.Name = "label3";
            label3.Size = new Size(308, 25);
            label3.TabIndex = 7;
            label3.Text = "รายละเอียดประเทศที่จัดส่งและยอดจำหน่าย : ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 333);
            label4.Name = "label4";
            label4.Size = new Size(273, 25);
            label4.TabIndex = 8;
            label4.Text = "รายละเอียดยอดจำหน่ายของพนักงาน : ";
            // 
            // Example
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 618);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn1);
            Controls.Add(dgv2);
            Controls.Add(dgv1);
            Controls.Add(cbo2);
            Controls.Add(cbo1);
            Name = "Example";
            Text = "Example";
            Load += Example_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbo1;
        private ComboBox cbo2;
        private DataGridView dgv1;
        private DataGridView dgv2;
        private Button btn1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}