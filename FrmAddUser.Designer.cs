namespace WinFormsApp1
{
    partial class FrmAddUser
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            txtPassword = new TextBox();
            txtCfPassword = new TextBox();
            cboPosition = new ComboBox();
            btnSave = new Button();
            btnClear = new Button();
            lbMsg = new Label();
            lbEmailErr = new Label();
            lbPwdErr = new Label();
            lbCfPwdErr = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 127);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "อีเมลล์ :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 181);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 1;
            label2.Text = "ชื่อ :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 230);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 2;
            label3.Text = "นามสกุล :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 283);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 3;
            label4.Text = "ตำแหน่ง :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(253, 340);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 4;
            label5.Text = "รหัสผ่าน :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 401);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 5;
            label6.Text = "ยืนยันรหัสผ่าน :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(363, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(535, 31);
            txtEmail.TabIndex = 6;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(363, 178);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(535, 31);
            txtFirstname.TabIndex = 7;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(363, 227);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(535, 31);
            txtLastname.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(363, 337);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(535, 31);
            txtPassword.TabIndex = 10;
            // 
            // txtCfPassword
            // 
            txtCfPassword.Location = new Point(363, 395);
            txtCfPassword.Name = "txtCfPassword";
            txtCfPassword.Size = new Size(535, 31);
            txtCfPassword.TabIndex = 11;
            // 
            // cboPosition
            // 
            cboPosition.BackColor = SystemColors.MenuBar;
            cboPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPosition.FormattingEnabled = true;
            cboPosition.Items.AddRange(new object[] { "รหัสลูกค้า", "ชื่อบริษัทลูกค้า", "ประเทศลูกค้า", "ลูกค้าทั้งหมด" });
            cboPosition.Location = new Point(363, 280);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(535, 33);
            cboPosition.TabIndex = 12;
            cboPosition.SelectedIndexChanged += cboPosition_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGreen;
            btnSave.Location = new Point(559, 481);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 47);
            btnSave.TabIndex = 13;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.PaleTurquoise;
            btnClear.Location = new Point(751, 481);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(147, 47);
            btnClear.TabIndex = 14;
            btnClear.Text = "เคลียร์";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lbMsg
            // 
            lbMsg.AutoSize = true;
            lbMsg.ForeColor = Color.Green;
            lbMsg.Location = new Point(363, 594);
            lbMsg.Name = "lbMsg";
            lbMsg.Size = new Size(20, 25);
            lbMsg.TabIndex = 15;
            lbMsg.Text = "*";
            // 
            // lbEmailErr
            // 
            lbEmailErr.AutoSize = true;
            lbEmailErr.ForeColor = Color.Red;
            lbEmailErr.Location = new Point(927, 130);
            lbEmailErr.Name = "lbEmailErr";
            lbEmailErr.Size = new Size(20, 25);
            lbEmailErr.TabIndex = 16;
            lbEmailErr.Text = "*";
            // 
            // lbPwdErr
            // 
            lbPwdErr.AutoSize = true;
            lbPwdErr.ForeColor = Color.Red;
            lbPwdErr.Location = new Point(927, 343);
            lbPwdErr.Name = "lbPwdErr";
            lbPwdErr.Size = new Size(20, 25);
            lbPwdErr.TabIndex = 17;
            lbPwdErr.Text = "*";
            // 
            // lbCfPwdErr
            // 
            lbCfPwdErr.AutoSize = true;
            lbCfPwdErr.ForeColor = Color.Red;
            lbCfPwdErr.Location = new Point(927, 401);
            lbCfPwdErr.Name = "lbCfPwdErr";
            lbCfPwdErr.Size = new Size(20, 25);
            lbCfPwdErr.TabIndex = 18;
            lbCfPwdErr.Text = "*";
            // 
            // FrmAddUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 702);
            Controls.Add(lbCfPwdErr);
            Controls.Add(lbPwdErr);
            Controls.Add(lbEmailErr);
            Controls.Add(lbMsg);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(cboPosition);
            Controls.Add(txtCfPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddUser";
            Text = "FrmAddUser";
            Load += FrmAddUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEmail;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private TextBox txtPassword;
        private TextBox txtCfPassword;
        private ComboBox cboPosition;
        private Button btnSave;
        private Button btnClear;
        private Label lbMsg;
        private Label lbEmailErr;
        private Label lbPwdErr;
        private Label lbCfPwdErr;
    }
}