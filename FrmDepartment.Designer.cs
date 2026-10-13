namespace WinFormsApp1
{
    partial class FrmDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartment));
            label1 = new Label();
            dgvDepartment = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtDesc = new TextBox();
            txtPhone = new TextBox();
            txtFax = new TextBox();
            btnNew = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Angsana New", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 49);
            label1.Name = "label1";
            label1.Size = new Size(84, 30);
            label1.TabIndex = 1;
            label1.Text = "ข้อมูลแผนก";
            // 
            // dgvDepartment
            // 
            dgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartment.Location = new Point(38, 82);
            dgvDepartment.Name = "dgvDepartment";
            dgvDepartment.RowHeadersWidth = 62;
            dgvDepartment.Size = new Size(570, 505);
            dgvDepartment.TabIndex = 2;
            dgvDepartment.CellMouseUp += dgvDepartment_CellMouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Angsana New", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(654, 82);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 3;
            label2.Text = "รหัสแผนก";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Angsana New", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(664, 125);
            label3.Name = "label3";
            label3.Size = new Size(65, 30);
            label3.TabIndex = 4;
            label3.Text = "ชื่อแผนก";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Angsana New", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(659, 170);
            label4.Name = "label4";
            label4.Size = new Size(70, 30);
            label4.TabIndex = 5;
            label4.Text = "หมายเหตุ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Angsana New", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(662, 355);
            label5.Name = "label5";
            label5.Size = new Size(67, 30);
            label5.TabIndex = 6;
            label5.Text = "โทรศัพท์";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Angsana New", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(679, 402);
            label6.Name = "label6";
            label6.Size = new Size(50, 30);
            label6.TabIndex = 7;
            label6.Text = "แฟกซ์";
            // 
            // txtID
            // 
            txtID.Location = new Point(735, 86);
            txtID.Name = "txtID";
            txtID.Size = new Size(156, 31);
            txtID.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(735, 123);
            txtName.Name = "txtName";
            txtName.Size = new Size(366, 31);
            txtName.TabIndex = 9;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(735, 170);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(366, 170);
            txtDesc.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(735, 354);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(366, 31);
            txtPhone.TabIndex = 11;
            // 
            // txtFax
            // 
            txtFax.Location = new Point(735, 401);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(366, 31);
            txtFax.TabIndex = 12;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(255, 255, 192);
            btnNew.BackgroundImageLayout = ImageLayout.Center;
            btnNew.Image = (Image)resources.GetObject("btnNew.Image");
            btnNew.Location = new Point(735, 489);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(122, 73);
            btnNew.TabIndex = 13;
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 255, 192);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(863, 489);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 73);
            btnSave.TabIndex = 14;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 255, 192);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(985, 489);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 73);
            btnDelete.TabIndex = 15;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // FrmDepartment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 612);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(txtFax);
            Controls.Add(txtPhone);
            Controls.Add(txtDesc);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvDepartment);
            Controls.Add(label1);
            Name = "FrmDepartment";
            Text = "จัดการข้อมูลแผนก";
            Load += FrmDepartment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvDepartment;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtDesc;
        private TextBox txtPhone;
        private TextBox txtFax;
        private Button btnNew;
        private Button btnSave;
        private Button btnDelete;
    }
}