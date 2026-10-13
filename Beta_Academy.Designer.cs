namespace WinFormsApp1
{
    partial class Beta_Academy
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
            tabMain = new TabControl();
            tpManage = new TabPage();
            tabManage = new TabControl();
            tpTeacher = new TabPage();
            grpTeacherList = new GroupBox();
            dgvTeacher = new DataGridView();
            pnlTeacherBtn = new Panel();
            btnTeacherCancel = new Button();
            btnTeacherSave = new Button();
            btnTeacherDelete = new Button();
            btnTeacherEdit = new Button();
            btnTeacherAdd = new Button();
            grpTeacher = new GroupBox();
            btnTeacherPhoto = new Button();
            picTeacher = new PictureBox();
            txtTeacherEmail = new TextBox();
            txtTeacherMPhone = new TextBox();
            txtTeacherHPhone = new TextBox();
            txtTeacherLast = new TextBox();
            txtTeacherFirst = new TextBox();
            txtTeacherId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tpCourse = new TabPage();
            grpCourseList = new GroupBox();
            dgvCourse = new DataGridView();
            pnlCourseBtn = new Panel();
            btnCourseCancel = new Button();
            btnCourseSave = new Button();
            btnCourseDelete = new Button();
            btnCourseEdit = new Button();
            btnCourseAdd = new Button();
            grpCourse = new GroupBox();
            label20 = new Label();
            label19 = new Label();
            txtCourseHours = new TextBox();
            txtCourseFee = new TextBox();
            txtCourseDesc = new TextBox();
            txtCourseNameEn = new TextBox();
            txtCourseNameTh = new TextBox();
            txtCourseId = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tpSection = new TabPage();
            grpSectionList = new GroupBox();
            dgvSection = new DataGridView();
            pnlSectionBtn = new Panel();
            btnSectionCancel = new Button();
            btnSectionSave = new Button();
            btnSectionDelete = new Button();
            btnSectionEdit = new Button();
            btnSectionAdd = new Button();
            grpSection = new GroupBox();
            rdoSectionClosed = new RadioButton();
            rdoSectionOpen = new RadioButton();
            dtpSectionEnd = new DateTimePicker();
            dtpSectionStart = new DateTimePicker();
            label21 = new Label();
            label14 = new Label();
            label13 = new Label();
            cboSectionTeacher = new ComboBox();
            cboSectionCourse = new ComboBox();
            txtSectionRoom = new TextBox();
            txtSectionId = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            tpStudent = new TabPage();
            grpStudentList = new GroupBox();
            dgvStudent = new DataGridView();
            pnlStudentBtn = new Panel();
            btnStudentCancel = new Button();
            btnStudentSave = new Button();
            btnStudentDelete = new Button();
            btnStudentEdit = new Button();
            btnStudentAdd = new Button();
            grpStudentAddr = new GroupBox();
            cboStudentProvince = new ComboBox();
            txtStudentZip = new TextBox();
            txtStudentDistrict = new TextBox();
            txtStudentSubdistrict = new TextBox();
            txtStudentStreet = new TextBox();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            txtStudentAddrNo = new TextBox();
            label32 = new Label();
            label33 = new Label();
            label35 = new Label();
            grpStudent = new GroupBox();
            btnStudentPhoto = new Button();
            picStudent = new PictureBox();
            txtStudentLast = new TextBox();
            txtStudentFirst = new TextBox();
            txtStudentPhone = new TextBox();
            txtStudentId = new TextBox();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            tpEnroll = new TabPage();
            grpEnrollList = new GroupBox();
            dgvEnroll = new DataGridView();
            pnlEnrollBtn = new Panel();
            btnEnrollCancel = new Button();
            btnEnrollSave = new Button();
            btnEnrollDelete = new Button();
            btnEnrollEdit = new Button();
            btnEnrollAdd = new Button();
            grpEnroll = new GroupBox();
            rdoEnrollQuit = new RadioButton();
            rdoEnrollDone = new RadioButton();
            rdoEnrollStudying = new RadioButton();
            dtpEnrollDate = new DateTimePicker();
            cboEnrollSection = new ComboBox();
            cboEnrollStudent = new ComboBox();
            label23 = new Label();
            label24 = new Label();
            txtEnrollId = new TextBox();
            label34 = new Label();
            label36 = new Label();
            label37 = new Label();
            tpSearch = new TabPage();
            tabSearch = new TabControl();
            tpSearchCourse = new TabPage();
            gbCourseResult = new GroupBox();
            dgvSearchCourse = new DataGridView();
            gbCourseSearch = new GroupBox();
            btnCourseClear = new Button();
            btnCourseSearch = new Button();
            txtCourseName = new MaskedTextBox();
            label38 = new Label();
            tpSearchSection = new TabPage();
            gbSectionResult = new GroupBox();
            gbSectionSearch = new GroupBox();
            btnSectionClear = new Button();
            btnSectionSearch = new Button();
            txtSectionCourse = new MaskedTextBox();
            label39 = new Label();
            tpSearchStudent = new TabPage();
            gbStudentResult = new GroupBox();
            picSearchStudent = new PictureBox();
            gbStudentSearch = new GroupBox();
            btnStudentClear = new Button();
            btnStudentSearch = new Button();
            txtStudentName = new MaskedTextBox();
            label40 = new Label();
            tpSearchEnroll = new TabPage();
            gbEnrollResult = new GroupBox();
            gbEnrollSearch = new GroupBox();
            btnEnrollClear = new Button();
            btnEnrollSearch = new Button();
            txtEnrollCourse = new MaskedTextBox();
            label41 = new Label();
            tpSearchSuccess = new TabPage();
            gbSuccessResult = new GroupBox();
            gbSuccessSearch = new GroupBox();
            btnSuccessClear = new Button();
            btnSuccessSearch = new Button();
            txtSuccessCourseId = new MaskedTextBox();
            label22 = new Label();
            dgvSearchSection = new DataGridView();
            dgvSearchStudent = new DataGridView();
            dgvSearchEnroll = new DataGridView();
            dgvSearchSuccess = new DataGridView();
            tabMain.SuspendLayout();
            tpManage.SuspendLayout();
            tabManage.SuspendLayout();
            tpTeacher.SuspendLayout();
            grpTeacherList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).BeginInit();
            pnlTeacherBtn.SuspendLayout();
            grpTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTeacher).BeginInit();
            tpCourse.SuspendLayout();
            grpCourseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            pnlCourseBtn.SuspendLayout();
            grpCourse.SuspendLayout();
            tpSection.SuspendLayout();
            grpSectionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSection).BeginInit();
            pnlSectionBtn.SuspendLayout();
            grpSection.SuspendLayout();
            tpStudent.SuspendLayout();
            grpStudentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            pnlStudentBtn.SuspendLayout();
            grpStudentAddr.SuspendLayout();
            grpStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            tpEnroll.SuspendLayout();
            grpEnrollList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnroll).BeginInit();
            pnlEnrollBtn.SuspendLayout();
            grpEnroll.SuspendLayout();
            tpSearch.SuspendLayout();
            tabSearch.SuspendLayout();
            tpSearchCourse.SuspendLayout();
            gbCourseResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchCourse).BeginInit();
            gbCourseSearch.SuspendLayout();
            tpSearchSection.SuspendLayout();
            gbSectionResult.SuspendLayout();
            gbSectionSearch.SuspendLayout();
            tpSearchStudent.SuspendLayout();
            gbStudentResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchStudent).BeginInit();
            gbStudentSearch.SuspendLayout();
            tpSearchEnroll.SuspendLayout();
            gbEnrollResult.SuspendLayout();
            gbEnrollSearch.SuspendLayout();
            tpSearchSuccess.SuspendLayout();
            gbSuccessResult.SuspendLayout();
            gbSuccessSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchSection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSearchStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSearchEnroll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSearchSuccess).BeginInit();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tpManage);
            tabMain.Controls.Add(tpSearch);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1007, 879);
            tabMain.TabIndex = 0;
            // 
            // tpManage
            // 
            tpManage.Controls.Add(tabManage);
            tpManage.Location = new Point(4, 34);
            tpManage.Name = "tpManage";
            tpManage.Padding = new Padding(3);
            tpManage.Size = new Size(999, 841);
            tpManage.TabIndex = 0;
            tpManage.Text = "จัดการข้อมูล";
            tpManage.UseVisualStyleBackColor = true;
            // 
            // tabManage
            // 
            tabManage.Controls.Add(tpTeacher);
            tabManage.Controls.Add(tpCourse);
            tabManage.Controls.Add(tpSection);
            tabManage.Controls.Add(tpStudent);
            tabManage.Controls.Add(tpEnroll);
            tabManage.Dock = DockStyle.Fill;
            tabManage.Location = new Point(3, 3);
            tabManage.Name = "tabManage";
            tabManage.SelectedIndex = 0;
            tabManage.Size = new Size(993, 835);
            tabManage.TabIndex = 0;
            // 
            // tpTeacher
            // 
            tpTeacher.Controls.Add(grpTeacherList);
            tpTeacher.Controls.Add(pnlTeacherBtn);
            tpTeacher.Controls.Add(grpTeacher);
            tpTeacher.Location = new Point(4, 34);
            tpTeacher.Name = "tpTeacher";
            tpTeacher.Padding = new Padding(3);
            tpTeacher.Size = new Size(985, 797);
            tpTeacher.TabIndex = 0;
            tpTeacher.Text = "ผู้สอน";
            tpTeacher.UseVisualStyleBackColor = true;
            // 
            // grpTeacherList
            // 
            grpTeacherList.Controls.Add(dgvTeacher);
            grpTeacherList.Location = new Point(3, 366);
            grpTeacherList.Name = "grpTeacherList";
            grpTeacherList.Size = new Size(981, 425);
            grpTeacherList.TabIndex = 1;
            grpTeacherList.TabStop = false;
            grpTeacherList.Text = "รายการผู้สอน";
            // 
            // dgvTeacher
            // 
            dgvTeacher.AllowUserToAddRows = false;
            dgvTeacher.AllowUserToDeleteRows = false;
            dgvTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeacher.Dock = DockStyle.Fill;
            dgvTeacher.Location = new Point(3, 27);
            dgvTeacher.MultiSelect = false;
            dgvTeacher.Name = "dgvTeacher";
            dgvTeacher.ReadOnly = true;
            dgvTeacher.RowHeadersVisible = false;
            dgvTeacher.RowHeadersWidth = 62;
            dgvTeacher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeacher.Size = new Size(975, 395);
            dgvTeacher.TabIndex = 0;
            // 
            // pnlTeacherBtn
            // 
            pnlTeacherBtn.Controls.Add(btnTeacherCancel);
            pnlTeacherBtn.Controls.Add(btnTeacherSave);
            pnlTeacherBtn.Controls.Add(btnTeacherDelete);
            pnlTeacherBtn.Controls.Add(btnTeacherEdit);
            pnlTeacherBtn.Controls.Add(btnTeacherAdd);
            pnlTeacherBtn.Location = new Point(3, 289);
            pnlTeacherBtn.Name = "pnlTeacherBtn";
            pnlTeacherBtn.Size = new Size(981, 71);
            pnlTeacherBtn.TabIndex = 0;
            // 
            // btnTeacherCancel
            // 
            btnTeacherCancel.Location = new Point(443, 13);
            btnTeacherCancel.Name = "btnTeacherCancel";
            btnTeacherCancel.Size = new Size(85, 39);
            btnTeacherCancel.TabIndex = 18;
            btnTeacherCancel.Text = "ยกเลิก";
            btnTeacherCancel.UseVisualStyleBackColor = true;
            // 
            // btnTeacherSave
            // 
            btnTeacherSave.Location = new Point(339, 13);
            btnTeacherSave.Name = "btnTeacherSave";
            btnTeacherSave.Size = new Size(85, 39);
            btnTeacherSave.TabIndex = 17;
            btnTeacherSave.Text = "บันทึก";
            btnTeacherSave.UseVisualStyleBackColor = true;
            // 
            // btnTeacherDelete
            // 
            btnTeacherDelete.Location = new Point(232, 13);
            btnTeacherDelete.Name = "btnTeacherDelete";
            btnTeacherDelete.Size = new Size(85, 39);
            btnTeacherDelete.TabIndex = 16;
            btnTeacherDelete.Text = "ลบ";
            btnTeacherDelete.UseVisualStyleBackColor = true;
            // 
            // btnTeacherEdit
            // 
            btnTeacherEdit.Location = new Point(118, 13);
            btnTeacherEdit.Name = "btnTeacherEdit";
            btnTeacherEdit.Size = new Size(85, 39);
            btnTeacherEdit.TabIndex = 15;
            btnTeacherEdit.Text = "แก้ไข";
            btnTeacherEdit.UseVisualStyleBackColor = true;
            // 
            // btnTeacherAdd
            // 
            btnTeacherAdd.Location = new Point(16, 13);
            btnTeacherAdd.Name = "btnTeacherAdd";
            btnTeacherAdd.Size = new Size(85, 39);
            btnTeacherAdd.TabIndex = 14;
            btnTeacherAdd.Text = "เพิ่ม";
            btnTeacherAdd.UseVisualStyleBackColor = true;
            // 
            // grpTeacher
            // 
            grpTeacher.Controls.Add(btnTeacherPhoto);
            grpTeacher.Controls.Add(picTeacher);
            grpTeacher.Controls.Add(txtTeacherEmail);
            grpTeacher.Controls.Add(txtTeacherMPhone);
            grpTeacher.Controls.Add(txtTeacherHPhone);
            grpTeacher.Controls.Add(txtTeacherLast);
            grpTeacher.Controls.Add(txtTeacherFirst);
            grpTeacher.Controls.Add(txtTeacherId);
            grpTeacher.Controls.Add(label6);
            grpTeacher.Controls.Add(label5);
            grpTeacher.Controls.Add(label4);
            grpTeacher.Controls.Add(label3);
            grpTeacher.Controls.Add(label2);
            grpTeacher.Controls.Add(label1);
            grpTeacher.Dock = DockStyle.Top;
            grpTeacher.Location = new Point(3, 3);
            grpTeacher.Name = "grpTeacher";
            grpTeacher.Size = new Size(979, 264);
            grpTeacher.TabIndex = 0;
            grpTeacher.TabStop = false;
            grpTeacher.Text = "ข้อมูลผู้สอน";
            // 
            // btnTeacherPhoto
            // 
            btnTeacherPhoto.Location = new Point(794, 186);
            btnTeacherPhoto.Name = "btnTeacherPhoto";
            btnTeacherPhoto.Size = new Size(130, 46);
            btnTeacherPhoto.TabIndex = 13;
            btnTeacherPhoto.Text = "เลือกรูป...";
            btnTeacherPhoto.UseVisualStyleBackColor = true;
            // 
            // picTeacher
            // 
            picTeacher.BorderStyle = BorderStyle.FixedSingle;
            picTeacher.Location = new Point(794, 30);
            picTeacher.Name = "picTeacher";
            picTeacher.Size = new Size(130, 150);
            picTeacher.SizeMode = PictureBoxSizeMode.Zoom;
            picTeacher.TabIndex = 12;
            picTeacher.TabStop = false;
            // 
            // txtTeacherEmail
            // 
            txtTeacherEmail.Location = new Point(172, 217);
            txtTeacherEmail.Name = "txtTeacherEmail";
            txtTeacherEmail.Size = new Size(273, 31);
            txtTeacherEmail.TabIndex = 11;
            // 
            // txtTeacherMPhone
            // 
            txtTeacherMPhone.Location = new Point(172, 180);
            txtTeacherMPhone.Name = "txtTeacherMPhone";
            txtTeacherMPhone.Size = new Size(190, 31);
            txtTeacherMPhone.TabIndex = 10;
            // 
            // txtTeacherHPhone
            // 
            txtTeacherHPhone.Location = new Point(171, 140);
            txtTeacherHPhone.Name = "txtTeacherHPhone";
            txtTeacherHPhone.Size = new Size(190, 31);
            txtTeacherHPhone.TabIndex = 9;
            // 
            // txtTeacherLast
            // 
            txtTeacherLast.Location = new Point(171, 98);
            txtTeacherLast.MaxLength = 24;
            txtTeacherLast.Name = "txtTeacherLast";
            txtTeacherLast.Size = new Size(274, 31);
            txtTeacherLast.TabIndex = 8;
            // 
            // txtTeacherFirst
            // 
            txtTeacherFirst.Location = new Point(171, 61);
            txtTeacherFirst.MaxLength = 24;
            txtTeacherFirst.Name = "txtTeacherFirst";
            txtTeacherFirst.Size = new Size(274, 31);
            txtTeacherFirst.TabIndex = 7;
            // 
            // txtTeacherId
            // 
            txtTeacherId.Location = new Point(171, 24);
            txtTeacherId.Name = "txtTeacherId";
            txtTeacherId.Size = new Size(170, 31);
            txtTeacherId.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(118, 217);
            label6.Name = "label6";
            label6.Size = new Size(47, 25);
            label6.TabIndex = 5;
            label6.Text = "อีเมล์";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 180);
            label5.Name = "label5";
            label5.Size = new Size(126, 25);
            label5.TabIndex = 4;
            label5.Text = "โทรศัพท์ (มือถือ)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 140);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 3;
            label4.Text = "โทรศัพท์ (บ้าน)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 98);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 2;
            label3.Text = "นามสกุล";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 67);
            label2.Name = "label2";
            label2.Size = new Size(33, 25);
            label2.TabIndex = 1;
            label2.Text = "ชื่อ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 24);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "รหัสผู้สอน";
            // 
            // tpCourse
            // 
            tpCourse.Controls.Add(grpCourseList);
            tpCourse.Controls.Add(pnlCourseBtn);
            tpCourse.Controls.Add(grpCourse);
            tpCourse.Location = new Point(4, 34);
            tpCourse.Name = "tpCourse";
            tpCourse.Padding = new Padding(3);
            tpCourse.Size = new Size(985, 797);
            tpCourse.TabIndex = 1;
            tpCourse.Text = "หลักสูตร";
            tpCourse.UseVisualStyleBackColor = true;
            // 
            // grpCourseList
            // 
            grpCourseList.Controls.Add(dgvCourse);
            grpCourseList.Location = new Point(0, 378);
            grpCourseList.Name = "grpCourseList";
            grpCourseList.Size = new Size(981, 405);
            grpCourseList.TabIndex = 3;
            grpCourseList.TabStop = false;
            grpCourseList.Text = "รายการหลักสูตร";
            // 
            // dgvCourse
            // 
            dgvCourse.AllowUserToAddRows = false;
            dgvCourse.AllowUserToDeleteRows = false;
            dgvCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.Dock = DockStyle.Fill;
            dgvCourse.Location = new Point(3, 27);
            dgvCourse.MultiSelect = false;
            dgvCourse.Name = "dgvCourse";
            dgvCourse.ReadOnly = true;
            dgvCourse.RowHeadersVisible = false;
            dgvCourse.RowHeadersWidth = 62;
            dgvCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourse.Size = new Size(975, 375);
            dgvCourse.TabIndex = 0;
            // 
            // pnlCourseBtn
            // 
            pnlCourseBtn.Controls.Add(btnCourseCancel);
            pnlCourseBtn.Controls.Add(btnCourseSave);
            pnlCourseBtn.Controls.Add(btnCourseDelete);
            pnlCourseBtn.Controls.Add(btnCourseEdit);
            pnlCourseBtn.Controls.Add(btnCourseAdd);
            pnlCourseBtn.Location = new Point(2, 301);
            pnlCourseBtn.Name = "pnlCourseBtn";
            pnlCourseBtn.Size = new Size(981, 71);
            pnlCourseBtn.TabIndex = 2;
            // 
            // btnCourseCancel
            // 
            btnCourseCancel.Location = new Point(443, 13);
            btnCourseCancel.Name = "btnCourseCancel";
            btnCourseCancel.Size = new Size(85, 39);
            btnCourseCancel.TabIndex = 18;
            btnCourseCancel.Text = "ยกเลิก";
            btnCourseCancel.UseVisualStyleBackColor = true;
            // 
            // btnCourseSave
            // 
            btnCourseSave.Location = new Point(339, 13);
            btnCourseSave.Name = "btnCourseSave";
            btnCourseSave.Size = new Size(85, 39);
            btnCourseSave.TabIndex = 17;
            btnCourseSave.Text = "บันทึก";
            btnCourseSave.UseVisualStyleBackColor = true;
            // 
            // btnCourseDelete
            // 
            btnCourseDelete.Location = new Point(232, 13);
            btnCourseDelete.Name = "btnCourseDelete";
            btnCourseDelete.Size = new Size(85, 39);
            btnCourseDelete.TabIndex = 16;
            btnCourseDelete.Text = "ลบ";
            btnCourseDelete.UseVisualStyleBackColor = true;
            // 
            // btnCourseEdit
            // 
            btnCourseEdit.Location = new Point(118, 13);
            btnCourseEdit.Name = "btnCourseEdit";
            btnCourseEdit.Size = new Size(85, 39);
            btnCourseEdit.TabIndex = 15;
            btnCourseEdit.Text = "แก้ไข";
            btnCourseEdit.UseVisualStyleBackColor = true;
            // 
            // btnCourseAdd
            // 
            btnCourseAdd.Location = new Point(16, 13);
            btnCourseAdd.Name = "btnCourseAdd";
            btnCourseAdd.Size = new Size(85, 39);
            btnCourseAdd.TabIndex = 14;
            btnCourseAdd.Text = "เพิ่ม";
            btnCourseAdd.UseVisualStyleBackColor = true;
            // 
            // grpCourse
            // 
            grpCourse.Controls.Add(label20);
            grpCourse.Controls.Add(label19);
            grpCourse.Controls.Add(txtCourseHours);
            grpCourse.Controls.Add(txtCourseFee);
            grpCourse.Controls.Add(txtCourseDesc);
            grpCourse.Controls.Add(txtCourseNameEn);
            grpCourse.Controls.Add(txtCourseNameTh);
            grpCourse.Controls.Add(txtCourseId);
            grpCourse.Controls.Add(label7);
            grpCourse.Controls.Add(label8);
            grpCourse.Controls.Add(label9);
            grpCourse.Controls.Add(label10);
            grpCourse.Controls.Add(label11);
            grpCourse.Controls.Add(label12);
            grpCourse.Dock = DockStyle.Top;
            grpCourse.Location = new Point(3, 3);
            grpCourse.Name = "grpCourse";
            grpCourse.Size = new Size(979, 292);
            grpCourse.TabIndex = 1;
            grpCourse.TabStop = false;
            grpCourse.Text = "ข้อมูลหลักสูตร";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(450, 251);
            label20.Name = "label20";
            label20.Size = new Size(55, 25);
            label20.TabIndex = 13;
            label20.Text = "ชั่วโมง";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(367, 212);
            label19.Name = "label19";
            label19.Size = new Size(41, 25);
            label19.TabIndex = 12;
            label19.Text = "บาท";
            // 
            // txtCourseHours
            // 
            txtCourseHours.Location = new Point(171, 245);
            txtCourseHours.Name = "txtCourseHours";
            txtCourseHours.Size = new Size(273, 31);
            txtCourseHours.TabIndex = 11;
            txtCourseHours.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCourseFee
            // 
            txtCourseFee.Location = new Point(171, 206);
            txtCourseFee.Name = "txtCourseFee";
            txtCourseFee.Size = new Size(190, 31);
            txtCourseFee.TabIndex = 10;
            txtCourseFee.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCourseDesc
            // 
            txtCourseDesc.Location = new Point(171, 140);
            txtCourseDesc.Multiline = true;
            txtCourseDesc.Name = "txtCourseDesc";
            txtCourseDesc.ScrollBars = ScrollBars.Vertical;
            txtCourseDesc.Size = new Size(356, 60);
            txtCourseDesc.TabIndex = 9;
            // 
            // txtCourseNameEn
            // 
            txtCourseNameEn.Location = new Point(171, 98);
            txtCourseNameEn.MaxLength = 100;
            txtCourseNameEn.Name = "txtCourseNameEn";
            txtCourseNameEn.Size = new Size(274, 31);
            txtCourseNameEn.TabIndex = 8;
            // 
            // txtCourseNameTh
            // 
            txtCourseNameTh.Location = new Point(171, 61);
            txtCourseNameTh.MaxLength = 100;
            txtCourseNameTh.Name = "txtCourseNameTh";
            txtCourseNameTh.Size = new Size(274, 31);
            txtCourseNameTh.TabIndex = 7;
            // 
            // txtCourseId
            // 
            txtCourseId.Location = new Point(171, 24);
            txtCourseId.MaxLength = 10;
            txtCourseId.Name = "txtCourseId";
            txtCourseId.Size = new Size(170, 31);
            txtCourseId.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 245);
            label7.Name = "label7";
            label7.Size = new Size(135, 25);
            label7.TabIndex = 5;
            label7.Text = "จำนวนชั่วโมงเรียน";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(102, 209);
            label8.Name = "label8";
            label8.Size = new Size(63, 25);
            label8.TabIndex = 4;
            label8.Text = "ค่าเรียน";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 152);
            label9.Name = "label9";
            label9.Size = new Size(146, 25);
            label9.TabIndex = 3;
            label9.Text = "รายละเอียดหลักสูตร";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 101);
            label10.Name = "label10";
            label10.Size = new Size(155, 25);
            label10.TabIndex = 2;
            label10.Text = "ชื่อหลักสูตร (อังกฤษ)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(32, 61);
            label11.Name = "label11";
            label11.Size = new Size(134, 25);
            label11.TabIndex = 1;
            label11.Text = "ชื่อหลักสูตร (ไทย)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(65, 24);
            label12.Name = "label12";
            label12.Size = new Size(100, 25);
            label12.TabIndex = 0;
            label12.Text = "รหัสหลักสูตร";
            // 
            // tpSection
            // 
            tpSection.Controls.Add(grpSectionList);
            tpSection.Controls.Add(pnlSectionBtn);
            tpSection.Controls.Add(grpSection);
            tpSection.Location = new Point(4, 34);
            tpSection.Name = "tpSection";
            tpSection.Size = new Size(985, 797);
            tpSection.TabIndex = 2;
            tpSection.Text = "หมู่เรียน";
            tpSection.UseVisualStyleBackColor = true;
            // 
            // grpSectionList
            // 
            grpSectionList.Controls.Add(dgvSection);
            grpSectionList.Location = new Point(1, 363);
            grpSectionList.Name = "grpSectionList";
            grpSectionList.Size = new Size(981, 420);
            grpSectionList.TabIndex = 4;
            grpSectionList.TabStop = false;
            grpSectionList.Text = "รายการหมู่เรียน";
            // 
            // dgvSection
            // 
            dgvSection.AllowUserToAddRows = false;
            dgvSection.AllowUserToDeleteRows = false;
            dgvSection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSection.Dock = DockStyle.Fill;
            dgvSection.Location = new Point(3, 27);
            dgvSection.MultiSelect = false;
            dgvSection.Name = "dgvSection";
            dgvSection.ReadOnly = true;
            dgvSection.RowHeadersVisible = false;
            dgvSection.RowHeadersWidth = 62;
            dgvSection.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSection.Size = new Size(975, 390);
            dgvSection.TabIndex = 0;
            // 
            // pnlSectionBtn
            // 
            pnlSectionBtn.Controls.Add(btnSectionCancel);
            pnlSectionBtn.Controls.Add(btnSectionSave);
            pnlSectionBtn.Controls.Add(btnSectionDelete);
            pnlSectionBtn.Controls.Add(btnSectionEdit);
            pnlSectionBtn.Controls.Add(btnSectionAdd);
            pnlSectionBtn.Location = new Point(5, 286);
            pnlSectionBtn.Name = "pnlSectionBtn";
            pnlSectionBtn.Size = new Size(981, 71);
            pnlSectionBtn.TabIndex = 3;
            // 
            // btnSectionCancel
            // 
            btnSectionCancel.Location = new Point(443, 13);
            btnSectionCancel.Name = "btnSectionCancel";
            btnSectionCancel.Size = new Size(85, 39);
            btnSectionCancel.TabIndex = 18;
            btnSectionCancel.Text = "ยกเลิก";
            btnSectionCancel.UseVisualStyleBackColor = true;
            // 
            // btnSectionSave
            // 
            btnSectionSave.Location = new Point(339, 13);
            btnSectionSave.Name = "btnSectionSave";
            btnSectionSave.Size = new Size(85, 39);
            btnSectionSave.TabIndex = 17;
            btnSectionSave.Text = "บันทึก";
            btnSectionSave.UseVisualStyleBackColor = true;
            // 
            // btnSectionDelete
            // 
            btnSectionDelete.Location = new Point(232, 13);
            btnSectionDelete.Name = "btnSectionDelete";
            btnSectionDelete.Size = new Size(85, 39);
            btnSectionDelete.TabIndex = 16;
            btnSectionDelete.Text = "ลบ";
            btnSectionDelete.UseVisualStyleBackColor = true;
            // 
            // btnSectionEdit
            // 
            btnSectionEdit.Location = new Point(118, 13);
            btnSectionEdit.Name = "btnSectionEdit";
            btnSectionEdit.Size = new Size(85, 39);
            btnSectionEdit.TabIndex = 15;
            btnSectionEdit.Text = "แก้ไข";
            btnSectionEdit.UseVisualStyleBackColor = true;
            // 
            // btnSectionAdd
            // 
            btnSectionAdd.Location = new Point(16, 13);
            btnSectionAdd.Name = "btnSectionAdd";
            btnSectionAdd.Size = new Size(85, 39);
            btnSectionAdd.TabIndex = 14;
            btnSectionAdd.Text = "เพิ่ม";
            btnSectionAdd.UseVisualStyleBackColor = true;
            // 
            // grpSection
            // 
            grpSection.Controls.Add(rdoSectionClosed);
            grpSection.Controls.Add(rdoSectionOpen);
            grpSection.Controls.Add(dtpSectionEnd);
            grpSection.Controls.Add(dtpSectionStart);
            grpSection.Controls.Add(label21);
            grpSection.Controls.Add(label14);
            grpSection.Controls.Add(label13);
            grpSection.Controls.Add(cboSectionTeacher);
            grpSection.Controls.Add(cboSectionCourse);
            grpSection.Controls.Add(txtSectionRoom);
            grpSection.Controls.Add(txtSectionId);
            grpSection.Controls.Add(label15);
            grpSection.Controls.Add(label16);
            grpSection.Controls.Add(label17);
            grpSection.Controls.Add(label18);
            grpSection.Dock = DockStyle.Top;
            grpSection.Location = new Point(0, 0);
            grpSection.Name = "grpSection";
            grpSection.Size = new Size(985, 264);
            grpSection.TabIndex = 2;
            grpSection.TabStop = false;
            grpSection.Text = "ข้อมูลหมู่เรียน";
            // 
            // rdoSectionClosed
            // 
            rdoSectionClosed.AutoSize = true;
            rdoSectionClosed.Location = new Point(760, 131);
            rdoSectionClosed.Name = "rdoSectionClosed";
            rdoSectionClosed.Size = new Size(57, 29);
            rdoSectionClosed.TabIndex = 22;
            rdoSectionClosed.Text = "ปิด";
            rdoSectionClosed.UseVisualStyleBackColor = true;
            // 
            // rdoSectionOpen
            // 
            rdoSectionOpen.AutoSize = true;
            rdoSectionOpen.Checked = true;
            rdoSectionOpen.Location = new Point(692, 131);
            rdoSectionOpen.Name = "rdoSectionOpen";
            rdoSectionOpen.Size = new Size(62, 29);
            rdoSectionOpen.TabIndex = 21;
            rdoSectionOpen.TabStop = true;
            rdoSectionOpen.Text = "เปิด";
            rdoSectionOpen.UseVisualStyleBackColor = true;
            // 
            // dtpSectionEnd
            // 
            dtpSectionEnd.CustomFormat = "dd/MM/yyyy";
            dtpSectionEnd.Format = DateTimePickerFormat.Custom;
            dtpSectionEnd.Location = new Point(692, 82);
            dtpSectionEnd.Name = "dtpSectionEnd";
            dtpSectionEnd.Size = new Size(233, 31);
            dtpSectionEnd.TabIndex = 20;
            // 
            // dtpSectionStart
            // 
            dtpSectionStart.CustomFormat = "dd/MM/yyyy";
            dtpSectionStart.Format = DateTimePickerFormat.Custom;
            dtpSectionStart.Location = new Point(692, 42);
            dtpSectionStart.Name = "dtpSectionStart";
            dtpSectionStart.Size = new Size(233, 31);
            dtpSectionStart.TabIndex = 19;
            dtpSectionStart.ValueChanged += dtpSectionStart_ValueChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(573, 127);
            label21.Name = "label21";
            label21.Size = new Size(111, 25);
            label21.TabIndex = 18;
            label21.Text = "สถานะหมู่เรียน";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(564, 82);
            label14.Name = "label14";
            label14.Size = new Size(120, 25);
            label14.TabIndex = 17;
            label14.Text = "วันที่จบหลักสูตร";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(586, 42);
            label13.Name = "label13";
            label13.Size = new Size(98, 25);
            label13.TabIndex = 16;
            label13.Text = "วันที่เริ่มเรียน";
            // 
            // cboSectionTeacher
            // 
            cboSectionTeacher.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSectionTeacher.FormattingEnabled = true;
            cboSectionTeacher.Location = new Point(171, 127);
            cboSectionTeacher.Name = "cboSectionTeacher";
            cboSectionTeacher.Size = new Size(324, 33);
            cboSectionTeacher.TabIndex = 15;
            // 
            // cboSectionCourse
            // 
            cboSectionCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSectionCourse.FormattingEnabled = true;
            cboSectionCourse.Location = new Point(171, 79);
            cboSectionCourse.Name = "cboSectionCourse";
            cboSectionCourse.Size = new Size(324, 33);
            cboSectionCourse.TabIndex = 14;
            // 
            // txtSectionRoom
            // 
            txtSectionRoom.Location = new Point(171, 179);
            txtSectionRoom.MaxLength = 10;
            txtSectionRoom.Name = "txtSectionRoom";
            txtSectionRoom.Size = new Size(190, 31);
            txtSectionRoom.TabIndex = 9;
            txtSectionRoom.TextChanged += textBox9_TextChanged;
            // 
            // txtSectionId
            // 
            txtSectionId.Location = new Point(171, 36);
            txtSectionId.MaxLength = 10;
            txtSectionId.Name = "txtSectionId";
            txtSectionId.Size = new Size(170, 31);
            txtSectionId.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(60, 127);
            label15.Name = "label15";
            label15.Size = new Size(105, 25);
            label15.TabIndex = 3;
            label15.Text = "ผู้สอน (1 คน)";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(94, 82);
            label16.Name = "label16";
            label16.Size = new Size(71, 25);
            label16.TabIndex = 2;
            label16.Text = "หลักสูตร";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(92, 179);
            label17.Name = "label17";
            label17.Size = new Size(73, 25);
            label17.TabIndex = 1;
            label17.Text = "ห้องเรียน";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(70, 36);
            label18.Name = "label18";
            label18.Size = new Size(95, 25);
            label18.TabIndex = 0;
            label18.Text = "รหัสหมู่เรียน";
            // 
            // tpStudent
            // 
            tpStudent.Controls.Add(grpStudentList);
            tpStudent.Controls.Add(pnlStudentBtn);
            tpStudent.Controls.Add(grpStudentAddr);
            tpStudent.Controls.Add(grpStudent);
            tpStudent.Location = new Point(4, 34);
            tpStudent.Name = "tpStudent";
            tpStudent.Size = new Size(985, 797);
            tpStudent.TabIndex = 3;
            tpStudent.Text = "ผู้เรียน";
            tpStudent.UseVisualStyleBackColor = true;
            // 
            // grpStudentList
            // 
            grpStudentList.Controls.Add(dgvStudent);
            grpStudentList.Location = new Point(1, 507);
            grpStudentList.Name = "grpStudentList";
            grpStudentList.Size = new Size(981, 283);
            grpStudentList.TabIndex = 25;
            grpStudentList.TabStop = false;
            grpStudentList.Text = "รายการผู้เรียน";
            // 
            // dgvStudent
            // 
            dgvStudent.AllowUserToAddRows = false;
            dgvStudent.AllowUserToDeleteRows = false;
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Dock = DockStyle.Fill;
            dgvStudent.Location = new Point(3, 27);
            dgvStudent.MultiSelect = false;
            dgvStudent.Name = "dgvStudent";
            dgvStudent.ReadOnly = true;
            dgvStudent.RowHeadersVisible = false;
            dgvStudent.RowHeadersWidth = 62;
            dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudent.Size = new Size(975, 253);
            dgvStudent.TabIndex = 0;
            // 
            // pnlStudentBtn
            // 
            pnlStudentBtn.Controls.Add(btnStudentCancel);
            pnlStudentBtn.Controls.Add(btnStudentSave);
            pnlStudentBtn.Controls.Add(btnStudentDelete);
            pnlStudentBtn.Controls.Add(btnStudentEdit);
            pnlStudentBtn.Controls.Add(btnStudentAdd);
            pnlStudentBtn.Location = new Point(1, 430);
            pnlStudentBtn.Name = "pnlStudentBtn";
            pnlStudentBtn.Size = new Size(981, 71);
            pnlStudentBtn.TabIndex = 24;
            // 
            // btnStudentCancel
            // 
            btnStudentCancel.Location = new Point(443, 13);
            btnStudentCancel.Name = "btnStudentCancel";
            btnStudentCancel.Size = new Size(85, 39);
            btnStudentCancel.TabIndex = 18;
            btnStudentCancel.Text = "ยกเลิก";
            btnStudentCancel.UseVisualStyleBackColor = true;
            // 
            // btnStudentSave
            // 
            btnStudentSave.Location = new Point(339, 13);
            btnStudentSave.Name = "btnStudentSave";
            btnStudentSave.Size = new Size(85, 39);
            btnStudentSave.TabIndex = 17;
            btnStudentSave.Text = "บันทึก";
            btnStudentSave.UseVisualStyleBackColor = true;
            // 
            // btnStudentDelete
            // 
            btnStudentDelete.Location = new Point(232, 13);
            btnStudentDelete.Name = "btnStudentDelete";
            btnStudentDelete.Size = new Size(85, 39);
            btnStudentDelete.TabIndex = 16;
            btnStudentDelete.Text = "ลบ";
            btnStudentDelete.UseVisualStyleBackColor = true;
            // 
            // btnStudentEdit
            // 
            btnStudentEdit.Location = new Point(118, 13);
            btnStudentEdit.Name = "btnStudentEdit";
            btnStudentEdit.Size = new Size(85, 39);
            btnStudentEdit.TabIndex = 15;
            btnStudentEdit.Text = "แก้ไข";
            btnStudentEdit.UseVisualStyleBackColor = true;
            // 
            // btnStudentAdd
            // 
            btnStudentAdd.Location = new Point(16, 13);
            btnStudentAdd.Name = "btnStudentAdd";
            btnStudentAdd.Size = new Size(85, 39);
            btnStudentAdd.TabIndex = 14;
            btnStudentAdd.Text = "เพิ่ม";
            btnStudentAdd.UseVisualStyleBackColor = true;
            // 
            // grpStudentAddr
            // 
            grpStudentAddr.Controls.Add(cboStudentProvince);
            grpStudentAddr.Controls.Add(txtStudentZip);
            grpStudentAddr.Controls.Add(txtStudentDistrict);
            grpStudentAddr.Controls.Add(txtStudentSubdistrict);
            grpStudentAddr.Controls.Add(txtStudentStreet);
            grpStudentAddr.Controls.Add(label29);
            grpStudentAddr.Controls.Add(label30);
            grpStudentAddr.Controls.Add(label31);
            grpStudentAddr.Controls.Add(txtStudentAddrNo);
            grpStudentAddr.Controls.Add(label32);
            grpStudentAddr.Controls.Add(label33);
            grpStudentAddr.Controls.Add(label35);
            grpStudentAddr.Location = new Point(1, 247);
            grpStudentAddr.Name = "grpStudentAddr";
            grpStudentAddr.Size = new Size(985, 177);
            grpStudentAddr.TabIndex = 23;
            grpStudentAddr.TabStop = false;
            grpStudentAddr.Text = "ที่อยู่";
            // 
            // cboStudentProvince
            // 
            cboStudentProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStudentProvince.FormattingEnabled = true;
            cboStudentProvince.Location = new Point(681, 84);
            cboStudentProvince.Name = "cboStudentProvince";
            cboStudentProvince.Size = new Size(245, 33);
            cboStudentProvince.TabIndex = 24;
            cboStudentProvince.SelectedIndexChanged += cboStudentProvince_SelectedIndexChanged;
            // 
            // txtStudentZip
            // 
            txtStudentZip.Location = new Point(681, 127);
            txtStudentZip.MaxLength = 5;
            txtStudentZip.Name = "txtStudentZip";
            txtStudentZip.Size = new Size(135, 31);
            txtStudentZip.TabIndex = 23;
            // 
            // txtStudentDistrict
            // 
            txtStudentDistrict.Location = new Point(681, 36);
            txtStudentDistrict.MaxLength = 50;
            txtStudentDistrict.Name = "txtStudentDistrict";
            txtStudentDistrict.Size = new Size(247, 31);
            txtStudentDistrict.TabIndex = 21;
            // 
            // txtStudentSubdistrict
            // 
            txtStudentSubdistrict.Location = new Point(171, 127);
            txtStudentSubdistrict.MaxLength = 50;
            txtStudentSubdistrict.Name = "txtStudentSubdistrict";
            txtStudentSubdistrict.Size = new Size(324, 31);
            txtStudentSubdistrict.TabIndex = 20;
            // 
            // txtStudentStreet
            // 
            txtStudentStreet.Location = new Point(171, 84);
            txtStudentStreet.MaxLength = 50;
            txtStudentStreet.Name = "txtStudentStreet";
            txtStudentStreet.Size = new Size(324, 31);
            txtStudentStreet.TabIndex = 19;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(573, 127);
            label29.Name = "label29";
            label29.Size = new Size(102, 25);
            label29.TabIndex = 18;
            label29.Text = "รหัสไปรษณีย์";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(618, 90);
            label30.Name = "label30";
            label30.Size = new Size(57, 25);
            label30.TabIndex = 17;
            label30.Text = "จังหวัด";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(619, 42);
            label31.Name = "label31";
            label31.Size = new Size(56, 25);
            label31.TabIndex = 16;
            label31.Text = "อำเภอ";
            // 
            // txtStudentAddrNo
            // 
            txtStudentAddrNo.Location = new Point(171, 36);
            txtStudentAddrNo.MaxLength = 20;
            txtStudentAddrNo.Name = "txtStudentAddrNo";
            txtStudentAddrNo.Size = new Size(198, 31);
            txtStudentAddrNo.TabIndex = 6;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(114, 127);
            label32.Name = "label32";
            label32.Size = new Size(50, 25);
            label32.TabIndex = 3;
            label32.Text = "ตำบล";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(120, 87);
            label33.Name = "label33";
            label33.Size = new Size(44, 25);
            label33.TabIndex = 2;
            label33.Text = "ถนน";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(86, 42);
            label35.Name = "label35";
            label35.Size = new Size(78, 25);
            label35.TabIndex = 0;
            label35.Text = "บ้านเลขที่";
            // 
            // grpStudent
            // 
            grpStudent.Controls.Add(btnStudentPhoto);
            grpStudent.Controls.Add(picStudent);
            grpStudent.Controls.Add(txtStudentLast);
            grpStudent.Controls.Add(txtStudentFirst);
            grpStudent.Controls.Add(txtStudentPhone);
            grpStudent.Controls.Add(txtStudentId);
            grpStudent.Controls.Add(label25);
            grpStudent.Controls.Add(label26);
            grpStudent.Controls.Add(label27);
            grpStudent.Controls.Add(label28);
            grpStudent.Dock = DockStyle.Top;
            grpStudent.Location = new Point(0, 0);
            grpStudent.Name = "grpStudent";
            grpStudent.Size = new Size(985, 241);
            grpStudent.TabIndex = 3;
            grpStudent.TabStop = false;
            grpStudent.Text = "ข้อมูลผู้เรียน";
            // 
            // btnStudentPhoto
            // 
            btnStudentPhoto.Location = new Point(735, 186);
            btnStudentPhoto.Name = "btnStudentPhoto";
            btnStudentPhoto.Size = new Size(130, 46);
            btnStudentPhoto.TabIndex = 14;
            btnStudentPhoto.Text = "เลือกรูป...";
            btnStudentPhoto.UseVisualStyleBackColor = true;
            // 
            // picStudent
            // 
            picStudent.BorderStyle = BorderStyle.FixedSingle;
            picStudent.Location = new Point(735, 30);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(130, 150);
            picStudent.SizeMode = PictureBoxSizeMode.Zoom;
            picStudent.TabIndex = 13;
            picStudent.TabStop = false;
            // 
            // txtStudentLast
            // 
            txtStudentLast.Location = new Point(171, 124);
            txtStudentLast.MaxLength = 45;
            txtStudentLast.Name = "txtStudentLast";
            txtStudentLast.Size = new Size(324, 31);
            txtStudentLast.TabIndex = 11;
            // 
            // txtStudentFirst
            // 
            txtStudentFirst.Location = new Point(171, 82);
            txtStudentFirst.MaxLength = 45;
            txtStudentFirst.Name = "txtStudentFirst";
            txtStudentFirst.Size = new Size(324, 31);
            txtStudentFirst.TabIndex = 10;
            // 
            // txtStudentPhone
            // 
            txtStudentPhone.Location = new Point(171, 173);
            txtStudentPhone.MaxLength = 10;
            txtStudentPhone.Name = "txtStudentPhone";
            txtStudentPhone.Size = new Size(198, 31);
            txtStudentPhone.TabIndex = 9;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(171, 36);
            txtStudentId.MaxLength = 10;
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(198, 31);
            txtStudentId.TabIndex = 6;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(94, 127);
            label25.Name = "label25";
            label25.Size = new Size(71, 25);
            label25.TabIndex = 3;
            label25.Text = "นามสกุล";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(132, 85);
            label26.Name = "label26";
            label26.Size = new Size(33, 25);
            label26.TabIndex = 2;
            label26.Text = "ชื่อ";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(94, 176);
            label27.Name = "label27";
            label27.Size = new Size(71, 25);
            label27.TabIndex = 1;
            label27.Text = "โทรศัพท์";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(80, 36);
            label28.Name = "label28";
            label28.Size = new Size(85, 25);
            label28.TabIndex = 0;
            label28.Text = "รหัสผู้เรียน";
            // 
            // tpEnroll
            // 
            tpEnroll.Controls.Add(grpEnrollList);
            tpEnroll.Controls.Add(pnlEnrollBtn);
            tpEnroll.Controls.Add(grpEnroll);
            tpEnroll.Location = new Point(4, 34);
            tpEnroll.Name = "tpEnroll";
            tpEnroll.Size = new Size(985, 797);
            tpEnroll.TabIndex = 4;
            tpEnroll.Text = "ลงทะเบียนเรียน";
            tpEnroll.UseVisualStyleBackColor = true;
            // 
            // grpEnrollList
            // 
            grpEnrollList.Controls.Add(dgvEnroll);
            grpEnrollList.Location = new Point(0, 309);
            grpEnrollList.Name = "grpEnrollList";
            grpEnrollList.Size = new Size(981, 477);
            grpEnrollList.TabIndex = 26;
            grpEnrollList.TabStop = false;
            grpEnrollList.Text = "รายการลงทะเบียนเรียน";
            // 
            // dgvEnroll
            // 
            dgvEnroll.AllowUserToAddRows = false;
            dgvEnroll.AllowUserToDeleteRows = false;
            dgvEnroll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEnroll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnroll.Dock = DockStyle.Fill;
            dgvEnroll.Location = new Point(3, 27);
            dgvEnroll.MultiSelect = false;
            dgvEnroll.Name = "dgvEnroll";
            dgvEnroll.ReadOnly = true;
            dgvEnroll.RowHeadersVisible = false;
            dgvEnroll.RowHeadersWidth = 62;
            dgvEnroll.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEnroll.Size = new Size(975, 447);
            dgvEnroll.TabIndex = 0;
            // 
            // pnlEnrollBtn
            // 
            pnlEnrollBtn.Controls.Add(btnEnrollCancel);
            pnlEnrollBtn.Controls.Add(btnEnrollSave);
            pnlEnrollBtn.Controls.Add(btnEnrollDelete);
            pnlEnrollBtn.Controls.Add(btnEnrollEdit);
            pnlEnrollBtn.Controls.Add(btnEnrollAdd);
            pnlEnrollBtn.Location = new Point(1, 232);
            pnlEnrollBtn.Name = "pnlEnrollBtn";
            pnlEnrollBtn.Size = new Size(981, 71);
            pnlEnrollBtn.TabIndex = 25;
            // 
            // btnEnrollCancel
            // 
            btnEnrollCancel.Location = new Point(443, 13);
            btnEnrollCancel.Name = "btnEnrollCancel";
            btnEnrollCancel.Size = new Size(85, 39);
            btnEnrollCancel.TabIndex = 18;
            btnEnrollCancel.Text = "ยกเลิก";
            btnEnrollCancel.UseVisualStyleBackColor = true;
            // 
            // btnEnrollSave
            // 
            btnEnrollSave.Location = new Point(339, 13);
            btnEnrollSave.Name = "btnEnrollSave";
            btnEnrollSave.Size = new Size(85, 39);
            btnEnrollSave.TabIndex = 17;
            btnEnrollSave.Text = "บันทึก";
            btnEnrollSave.UseVisualStyleBackColor = true;
            // 
            // btnEnrollDelete
            // 
            btnEnrollDelete.Location = new Point(232, 13);
            btnEnrollDelete.Name = "btnEnrollDelete";
            btnEnrollDelete.Size = new Size(85, 39);
            btnEnrollDelete.TabIndex = 16;
            btnEnrollDelete.Text = "ลบ";
            btnEnrollDelete.UseVisualStyleBackColor = true;
            // 
            // btnEnrollEdit
            // 
            btnEnrollEdit.Location = new Point(118, 13);
            btnEnrollEdit.Name = "btnEnrollEdit";
            btnEnrollEdit.Size = new Size(85, 39);
            btnEnrollEdit.TabIndex = 15;
            btnEnrollEdit.Text = "แก้ไข";
            btnEnrollEdit.UseVisualStyleBackColor = true;
            // 
            // btnEnrollAdd
            // 
            btnEnrollAdd.Location = new Point(16, 13);
            btnEnrollAdd.Name = "btnEnrollAdd";
            btnEnrollAdd.Size = new Size(85, 39);
            btnEnrollAdd.TabIndex = 14;
            btnEnrollAdd.Text = "เพิ่ม";
            btnEnrollAdd.UseVisualStyleBackColor = true;
            // 
            // grpEnroll
            // 
            grpEnroll.Controls.Add(rdoEnrollQuit);
            grpEnroll.Controls.Add(rdoEnrollDone);
            grpEnroll.Controls.Add(rdoEnrollStudying);
            grpEnroll.Controls.Add(dtpEnrollDate);
            grpEnroll.Controls.Add(cboEnrollSection);
            grpEnroll.Controls.Add(cboEnrollStudent);
            grpEnroll.Controls.Add(label23);
            grpEnroll.Controls.Add(label24);
            grpEnroll.Controls.Add(txtEnrollId);
            grpEnroll.Controls.Add(label34);
            grpEnroll.Controls.Add(label36);
            grpEnroll.Controls.Add(label37);
            grpEnroll.Location = new Point(1, 3);
            grpEnroll.Name = "grpEnroll";
            grpEnroll.Size = new Size(985, 202);
            grpEnroll.TabIndex = 24;
            grpEnroll.TabStop = false;
            grpEnroll.Text = "ข้อมูลการลงทะเบียนเรียนในหมู่เรียน";
            // 
            // rdoEnrollQuit
            // 
            rdoEnrollQuit.AutoSize = true;
            rdoEnrollQuit.Location = new Point(718, 153);
            rdoEnrollQuit.Name = "rdoEnrollQuit";
            rdoEnrollQuit.Size = new Size(95, 29);
            rdoEnrollQuit.TabIndex = 30;
            rdoEnrollQuit.Text = "เลิกเรียน";
            rdoEnrollQuit.UseVisualStyleBackColor = true;
            // 
            // rdoEnrollDone
            // 
            rdoEnrollDone.AutoSize = true;
            rdoEnrollDone.Location = new Point(718, 118);
            rdoEnrollDone.Name = "rdoEnrollDone";
            rdoEnrollDone.Size = new Size(77, 29);
            rdoEnrollDone.TabIndex = 29;
            rdoEnrollDone.Text = "สำเร็จ";
            rdoEnrollDone.UseVisualStyleBackColor = true;
            // 
            // rdoEnrollStudying
            // 
            rdoEnrollStudying.AutoSize = true;
            rdoEnrollStudying.Checked = true;
            rdoEnrollStudying.Location = new Point(718, 83);
            rdoEnrollStudying.Name = "rdoEnrollStudying";
            rdoEnrollStudying.Size = new Size(105, 29);
            rdoEnrollStudying.TabIndex = 28;
            rdoEnrollStudying.TabStop = true;
            rdoEnrollStudying.Text = "กำลังเรียน";
            rdoEnrollStudying.UseVisualStyleBackColor = true;
            rdoEnrollStudying.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // dtpEnrollDate
            // 
            dtpEnrollDate.CustomFormat = "dd/MM/yyyy";
            dtpEnrollDate.Format = DateTimePickerFormat.Custom;
            dtpEnrollDate.Location = new Point(718, 42);
            dtpEnrollDate.Name = "dtpEnrollDate";
            dtpEnrollDate.Size = new Size(218, 31);
            dtpEnrollDate.TabIndex = 27;
            // 
            // cboEnrollSection
            // 
            cboEnrollSection.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEnrollSection.FormattingEnabled = true;
            cboEnrollSection.Location = new Point(196, 130);
            cboEnrollSection.Name = "cboEnrollSection";
            cboEnrollSection.Size = new Size(338, 33);
            cboEnrollSection.TabIndex = 26;
            // 
            // cboEnrollStudent
            // 
            cboEnrollStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEnrollStudent.FormattingEnabled = true;
            cboEnrollStudent.Location = new Point(196, 82);
            cboEnrollStudent.Name = "cboEnrollStudent";
            cboEnrollStudent.Size = new Size(338, 33);
            cboEnrollStudent.TabIndex = 25;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(596, 82);
            label23.Name = "label23";
            label23.Size = new Size(116, 25);
            label23.TabIndex = 17;
            label23.Text = "สถานะการเรียน";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(601, 42);
            label24.Name = "label24";
            label24.Size = new Size(111, 25);
            label24.TabIndex = 16;
            label24.Text = "วันที่ลงทะเบียน";
            // 
            // txtEnrollId
            // 
            txtEnrollId.Location = new Point(196, 36);
            txtEnrollId.MaxLength = 10;
            txtEnrollId.Name = "txtEnrollId";
            txtEnrollId.Size = new Size(198, 31);
            txtEnrollId.TabIndex = 6;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(118, 133);
            label34.Name = "label34";
            label34.Size = new Size(66, 25);
            label34.TabIndex = 3;
            label34.Text = "หมู่เรียน";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(134, 82);
            label36.Name = "label36";
            label36.Size = new Size(56, 25);
            label36.TabIndex = 2;
            label36.Text = "ผู้เรียน";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(54, 36);
            label37.Name = "label37";
            label37.Size = new Size(136, 25);
            label37.TabIndex = 0;
            label37.Text = "รหัสการลงทะเบียน";
            // 
            // tpSearch
            // 
            tpSearch.Controls.Add(tabSearch);
            tpSearch.Location = new Point(4, 34);
            tpSearch.Name = "tpSearch";
            tpSearch.Padding = new Padding(3);
            tpSearch.Size = new Size(999, 841);
            tpSearch.TabIndex = 1;
            tpSearch.Text = "ค้นหาข้อมูล";
            tpSearch.UseVisualStyleBackColor = true;
            // 
            // tabSearch
            // 
            tabSearch.Controls.Add(tpSearchCourse);
            tabSearch.Controls.Add(tpSearchSection);
            tabSearch.Controls.Add(tpSearchStudent);
            tabSearch.Controls.Add(tpSearchEnroll);
            tabSearch.Controls.Add(tpSearchSuccess);
            tabSearch.Dock = DockStyle.Fill;
            tabSearch.Location = new Point(3, 3);
            tabSearch.Name = "tabSearch";
            tabSearch.SelectedIndex = 0;
            tabSearch.Size = new Size(993, 835);
            tabSearch.TabIndex = 0;
            // 
            // tpSearchCourse
            // 
            tpSearchCourse.Controls.Add(gbCourseResult);
            tpSearchCourse.Controls.Add(gbCourseSearch);
            tpSearchCourse.Location = new Point(4, 34);
            tpSearchCourse.Name = "tpSearchCourse";
            tpSearchCourse.Padding = new Padding(3);
            tpSearchCourse.Size = new Size(985, 797);
            tpSearchCourse.TabIndex = 0;
            tpSearchCourse.Text = "หลักสูตร";
            tpSearchCourse.UseVisualStyleBackColor = true;
            // 
            // gbCourseResult
            // 
            gbCourseResult.Controls.Add(dgvSearchCourse);
            gbCourseResult.Dock = DockStyle.Top;
            gbCourseResult.Location = new Point(3, 92);
            gbCourseResult.Name = "gbCourseResult";
            gbCourseResult.Size = new Size(979, 532);
            gbCourseResult.TabIndex = 2;
            gbCourseResult.TabStop = false;
            gbCourseResult.Text = "ผลการค้นหา";
            // 
            // dgvSearchCourse
            // 
            dgvSearchCourse.AllowUserToAddRows = false;
            dgvSearchCourse.AllowUserToDeleteRows = false;
            dgvSearchCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearchCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchCourse.Location = new Point(3, 27);
            dgvSearchCourse.Name = "dgvSearchCourse";
            dgvSearchCourse.ReadOnly = true;
            dgvSearchCourse.RowHeadersVisible = false;
            dgvSearchCourse.RowHeadersWidth = 62;
            dgvSearchCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSearchCourse.Size = new Size(970, 489);
            dgvSearchCourse.TabIndex = 0;
            // 
            // gbCourseSearch
            // 
            gbCourseSearch.Controls.Add(btnCourseClear);
            gbCourseSearch.Controls.Add(btnCourseSearch);
            gbCourseSearch.Controls.Add(txtCourseName);
            gbCourseSearch.Controls.Add(label38);
            gbCourseSearch.Dock = DockStyle.Top;
            gbCourseSearch.Location = new Point(3, 3);
            gbCourseSearch.Name = "gbCourseSearch";
            gbCourseSearch.Size = new Size(979, 89);
            gbCourseSearch.TabIndex = 1;
            gbCourseSearch.TabStop = false;
            gbCourseSearch.Text = "ค้นหารายละเอียดหลักสูตร";
            // 
            // btnCourseClear
            // 
            btnCourseClear.Location = new Point(527, 37);
            btnCourseClear.Name = "btnCourseClear";
            btnCourseClear.Size = new Size(112, 34);
            btnCourseClear.TabIndex = 3;
            btnCourseClear.Text = "ล้างข้อมูล";
            btnCourseClear.UseVisualStyleBackColor = true;
            // 
            // btnCourseSearch
            // 
            btnCourseSearch.Location = new Point(409, 37);
            btnCourseSearch.Name = "btnCourseSearch";
            btnCourseSearch.Size = new Size(112, 34);
            btnCourseSearch.TabIndex = 2;
            btnCourseSearch.Text = "ค้นหา";
            btnCourseSearch.UseVisualStyleBackColor = true;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(104, 37);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(289, 31);
            txtCourseName.TabIndex = 1;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(6, 37);
            label38.Name = "label38";
            label38.Size = new Size(92, 25);
            label38.TabIndex = 0;
            label38.Text = "ชื่อหลักสูตร";
            // 
            // tpSearchSection
            // 
            tpSearchSection.Controls.Add(gbSectionResult);
            tpSearchSection.Controls.Add(gbSectionSearch);
            tpSearchSection.Location = new Point(4, 34);
            tpSearchSection.Name = "tpSearchSection";
            tpSearchSection.Padding = new Padding(3);
            tpSearchSection.Size = new Size(985, 797);
            tpSearchSection.TabIndex = 1;
            tpSearchSection.Text = "หมู่เรียน";
            tpSearchSection.UseVisualStyleBackColor = true;
            // 
            // gbSectionResult
            // 
            gbSectionResult.Controls.Add(dgvSearchSection);
            gbSectionResult.Dock = DockStyle.Top;
            gbSectionResult.Location = new Point(3, 92);
            gbSectionResult.Name = "gbSectionResult";
            gbSectionResult.Size = new Size(979, 532);
            gbSectionResult.TabIndex = 3;
            gbSectionResult.TabStop = false;
            gbSectionResult.Text = "ผลการค้นหา";
            // 
            // gbSectionSearch
            // 
            gbSectionSearch.Controls.Add(btnSectionClear);
            gbSectionSearch.Controls.Add(btnSectionSearch);
            gbSectionSearch.Controls.Add(txtSectionCourse);
            gbSectionSearch.Controls.Add(label39);
            gbSectionSearch.Dock = DockStyle.Top;
            gbSectionSearch.Location = new Point(3, 3);
            gbSectionSearch.Name = "gbSectionSearch";
            gbSectionSearch.Size = new Size(979, 89);
            gbSectionSearch.TabIndex = 2;
            gbSectionSearch.TabStop = false;
            gbSectionSearch.Text = "ค้นหารายละเอียดหมู่เรียน";
            // 
            // btnSectionClear
            // 
            btnSectionClear.Location = new Point(527, 37);
            btnSectionClear.Name = "btnSectionClear";
            btnSectionClear.Size = new Size(112, 34);
            btnSectionClear.TabIndex = 3;
            btnSectionClear.Text = "ล้างข้อมูล";
            btnSectionClear.UseVisualStyleBackColor = true;
            // 
            // btnSectionSearch
            // 
            btnSectionSearch.Location = new Point(409, 37);
            btnSectionSearch.Name = "btnSectionSearch";
            btnSectionSearch.Size = new Size(112, 34);
            btnSectionSearch.TabIndex = 2;
            btnSectionSearch.Text = "ค้นหา";
            btnSectionSearch.UseVisualStyleBackColor = true;
            // 
            // txtSectionCourse
            // 
            txtSectionCourse.Location = new Point(104, 37);
            txtSectionCourse.Name = "txtSectionCourse";
            txtSectionCourse.Size = new Size(289, 31);
            txtSectionCourse.TabIndex = 1;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(6, 37);
            label39.Name = "label39";
            label39.Size = new Size(92, 25);
            label39.TabIndex = 0;
            label39.Text = "ชื่อหลักสูตร";
            // 
            // tpSearchStudent
            // 
            tpSearchStudent.Controls.Add(gbStudentResult);
            tpSearchStudent.Controls.Add(gbStudentSearch);
            tpSearchStudent.Location = new Point(4, 34);
            tpSearchStudent.Name = "tpSearchStudent";
            tpSearchStudent.Size = new Size(985, 797);
            tpSearchStudent.TabIndex = 2;
            tpSearchStudent.Text = "ผู้เรียน";
            tpSearchStudent.UseVisualStyleBackColor = true;
            // 
            // gbStudentResult
            // 
            gbStudentResult.Controls.Add(dgvSearchStudent);
            gbStudentResult.Controls.Add(picSearchStudent);
            gbStudentResult.Dock = DockStyle.Top;
            gbStudentResult.Location = new Point(0, 89);
            gbStudentResult.Name = "gbStudentResult";
            gbStudentResult.Size = new Size(985, 532);
            gbStudentResult.TabIndex = 4;
            gbStudentResult.TabStop = false;
            gbStudentResult.Text = "ผลการค้นหา";
            // 
            // picSearchStudent
            // 
            picSearchStudent.BorderStyle = BorderStyle.FixedSingle;
            picSearchStudent.Location = new Point(823, 42);
            picSearchStudent.Name = "picSearchStudent";
            picSearchStudent.Size = new Size(130, 150);
            picSearchStudent.SizeMode = PictureBoxSizeMode.Zoom;
            picSearchStudent.TabIndex = 13;
            picSearchStudent.TabStop = false;
            // 
            // gbStudentSearch
            // 
            gbStudentSearch.Controls.Add(btnStudentClear);
            gbStudentSearch.Controls.Add(btnStudentSearch);
            gbStudentSearch.Controls.Add(txtStudentName);
            gbStudentSearch.Controls.Add(label40);
            gbStudentSearch.Dock = DockStyle.Top;
            gbStudentSearch.Location = new Point(0, 0);
            gbStudentSearch.Name = "gbStudentSearch";
            gbStudentSearch.Size = new Size(985, 89);
            gbStudentSearch.TabIndex = 3;
            gbStudentSearch.TabStop = false;
            gbStudentSearch.Text = "ค้นหาข้อมูลผู้เรียน";
            // 
            // btnStudentClear
            // 
            btnStudentClear.Location = new Point(527, 37);
            btnStudentClear.Name = "btnStudentClear";
            btnStudentClear.Size = new Size(112, 34);
            btnStudentClear.TabIndex = 3;
            btnStudentClear.Text = "ล้างข้อมูล";
            btnStudentClear.UseVisualStyleBackColor = true;
            // 
            // btnStudentSearch
            // 
            btnStudentSearch.Location = new Point(409, 37);
            btnStudentSearch.Name = "btnStudentSearch";
            btnStudentSearch.Size = new Size(112, 34);
            btnStudentSearch.TabIndex = 2;
            btnStudentSearch.Text = "ค้นหา";
            btnStudentSearch.UseVisualStyleBackColor = true;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(104, 37);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(289, 31);
            txtStudentName.TabIndex = 1;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(6, 37);
            label40.Name = "label40";
            label40.Size = new Size(77, 25);
            label40.TabIndex = 0;
            label40.Text = "ชื่อผู้เรียน";
            // 
            // tpSearchEnroll
            // 
            tpSearchEnroll.Controls.Add(gbEnrollResult);
            tpSearchEnroll.Controls.Add(gbEnrollSearch);
            tpSearchEnroll.Location = new Point(4, 34);
            tpSearchEnroll.Name = "tpSearchEnroll";
            tpSearchEnroll.Size = new Size(985, 797);
            tpSearchEnroll.TabIndex = 3;
            tpSearchEnroll.Text = "ผู้ลงทะเบียนในหลักสูตร";
            tpSearchEnroll.UseVisualStyleBackColor = true;
            // 
            // gbEnrollResult
            // 
            gbEnrollResult.Controls.Add(dgvSearchEnroll);
            gbEnrollResult.Dock = DockStyle.Top;
            gbEnrollResult.Location = new Point(0, 89);
            gbEnrollResult.Name = "gbEnrollResult";
            gbEnrollResult.Size = new Size(985, 532);
            gbEnrollResult.TabIndex = 4;
            gbEnrollResult.TabStop = false;
            gbEnrollResult.Text = "ผลการค้นหา";
            // 
            // gbEnrollSearch
            // 
            gbEnrollSearch.Controls.Add(btnEnrollClear);
            gbEnrollSearch.Controls.Add(btnEnrollSearch);
            gbEnrollSearch.Controls.Add(txtEnrollCourse);
            gbEnrollSearch.Controls.Add(label41);
            gbEnrollSearch.Dock = DockStyle.Top;
            gbEnrollSearch.Location = new Point(0, 0);
            gbEnrollSearch.Name = "gbEnrollSearch";
            gbEnrollSearch.Size = new Size(985, 89);
            gbEnrollSearch.TabIndex = 3;
            gbEnrollSearch.TabStop = false;
            gbEnrollSearch.Text = "ค้นหาผู้ลงทะเบียนเรียนในแต่ละหลักสูตร";
            // 
            // btnEnrollClear
            // 
            btnEnrollClear.Location = new Point(527, 37);
            btnEnrollClear.Name = "btnEnrollClear";
            btnEnrollClear.Size = new Size(112, 34);
            btnEnrollClear.TabIndex = 3;
            btnEnrollClear.Text = "ล้างข้อมูล";
            btnEnrollClear.UseVisualStyleBackColor = true;
            // 
            // btnEnrollSearch
            // 
            btnEnrollSearch.Location = new Point(409, 37);
            btnEnrollSearch.Name = "btnEnrollSearch";
            btnEnrollSearch.Size = new Size(112, 34);
            btnEnrollSearch.TabIndex = 2;
            btnEnrollSearch.Text = "ค้นหา";
            btnEnrollSearch.UseVisualStyleBackColor = true;
            // 
            // txtEnrollCourse
            // 
            txtEnrollCourse.Location = new Point(104, 37);
            txtEnrollCourse.Name = "txtEnrollCourse";
            txtEnrollCourse.Size = new Size(289, 31);
            txtEnrollCourse.TabIndex = 1;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(6, 37);
            label41.Name = "label41";
            label41.Size = new Size(92, 25);
            label41.TabIndex = 0;
            label41.Text = "ชื่อหลักสูตร";
            // 
            // tpSearchSuccess
            // 
            tpSearchSuccess.Controls.Add(gbSuccessResult);
            tpSearchSuccess.Controls.Add(gbSuccessSearch);
            tpSearchSuccess.Location = new Point(4, 34);
            tpSearchSuccess.Name = "tpSearchSuccess";
            tpSearchSuccess.Size = new Size(985, 797);
            tpSearchSuccess.TabIndex = 4;
            tpSearchSuccess.Text = "ผู้เรียนที่สำเร็จ";
            tpSearchSuccess.UseVisualStyleBackColor = true;
            // 
            // gbSuccessResult
            // 
            gbSuccessResult.Controls.Add(dgvSearchSuccess);
            gbSuccessResult.Dock = DockStyle.Top;
            gbSuccessResult.Location = new Point(0, 89);
            gbSuccessResult.Name = "gbSuccessResult";
            gbSuccessResult.Size = new Size(985, 532);
            gbSuccessResult.TabIndex = 1;
            gbSuccessResult.TabStop = false;
            gbSuccessResult.Text = "ผลการค้นหา";
            // 
            // gbSuccessSearch
            // 
            gbSuccessSearch.Controls.Add(btnSuccessClear);
            gbSuccessSearch.Controls.Add(btnSuccessSearch);
            gbSuccessSearch.Controls.Add(txtSuccessCourseId);
            gbSuccessSearch.Controls.Add(label22);
            gbSuccessSearch.Dock = DockStyle.Top;
            gbSuccessSearch.Location = new Point(0, 0);
            gbSuccessSearch.Name = "gbSuccessSearch";
            gbSuccessSearch.Size = new Size(985, 89);
            gbSuccessSearch.TabIndex = 0;
            gbSuccessSearch.TabStop = false;
            gbSuccessSearch.Text = "ค้นหาผู้เรียนที่สำเร็จในหลักสูตร";
            // 
            // btnSuccessClear
            // 
            btnSuccessClear.Location = new Point(527, 37);
            btnSuccessClear.Name = "btnSuccessClear";
            btnSuccessClear.Size = new Size(112, 34);
            btnSuccessClear.TabIndex = 3;
            btnSuccessClear.Text = "ล้างข้อมูล";
            btnSuccessClear.UseVisualStyleBackColor = true;
            // 
            // btnSuccessSearch
            // 
            btnSuccessSearch.Location = new Point(409, 37);
            btnSuccessSearch.Name = "btnSuccessSearch";
            btnSuccessSearch.Size = new Size(112, 34);
            btnSuccessSearch.TabIndex = 2;
            btnSuccessSearch.Text = "ค้นหา";
            btnSuccessSearch.UseVisualStyleBackColor = true;
            // 
            // txtSuccessCourseId
            // 
            txtSuccessCourseId.Location = new Point(104, 37);
            txtSuccessCourseId.Name = "txtSuccessCourseId";
            txtSuccessCourseId.Size = new Size(289, 31);
            txtSuccessCourseId.TabIndex = 1;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 37);
            label22.Name = "label22";
            label22.Size = new Size(100, 25);
            label22.TabIndex = 0;
            label22.Text = "รหัสหลักสูตร";
            // 
            // dgvSearchSection
            // 
            dgvSearchSection.AllowUserToAddRows = false;
            dgvSearchSection.AllowUserToDeleteRows = false;
            dgvSearchSection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearchSection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchSection.Location = new Point(4, 22);
            dgvSearchSection.Name = "dgvSearchSection";
            dgvSearchSection.ReadOnly = true;
            dgvSearchSection.RowHeadersVisible = false;
            dgvSearchSection.RowHeadersWidth = 62;
            dgvSearchSection.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSearchSection.Size = new Size(970, 489);
            dgvSearchSection.TabIndex = 1;
            // 
            // dgvSearchStudent
            // 
            dgvSearchStudent.AllowUserToAddRows = false;
            dgvSearchStudent.AllowUserToDeleteRows = false;
            dgvSearchStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearchStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchStudent.Location = new Point(7, 22);
            dgvSearchStudent.Name = "dgvSearchStudent";
            dgvSearchStudent.ReadOnly = true;
            dgvSearchStudent.RowHeadersVisible = false;
            dgvSearchStudent.RowHeadersWidth = 62;
            dgvSearchStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSearchStudent.Size = new Size(711, 489);
            dgvSearchStudent.TabIndex = 14;
            // 
            // dgvSearchEnroll
            // 
            dgvSearchEnroll.AllowUserToAddRows = false;
            dgvSearchEnroll.AllowUserToDeleteRows = false;
            dgvSearchEnroll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearchEnroll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchEnroll.Location = new Point(7, 22);
            dgvSearchEnroll.Name = "dgvSearchEnroll";
            dgvSearchEnroll.ReadOnly = true;
            dgvSearchEnroll.RowHeadersVisible = false;
            dgvSearchEnroll.RowHeadersWidth = 62;
            dgvSearchEnroll.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSearchEnroll.Size = new Size(970, 489);
            dgvSearchEnroll.TabIndex = 1;
            // 
            // dgvSearchSuccess
            // 
            dgvSearchSuccess.AllowUserToAddRows = false;
            dgvSearchSuccess.AllowUserToDeleteRows = false;
            dgvSearchSuccess.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearchSuccess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchSuccess.Location = new Point(7, 22);
            dgvSearchSuccess.Name = "dgvSearchSuccess";
            dgvSearchSuccess.ReadOnly = true;
            dgvSearchSuccess.RowHeadersVisible = false;
            dgvSearchSuccess.RowHeadersWidth = 62;
            dgvSearchSuccess.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSearchSuccess.Size = new Size(970, 489);
            dgvSearchSuccess.TabIndex = 1;
            // 
            // Beta_Academy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 879);
            Controls.Add(tabMain);
            Name = "Beta_Academy";
            Text = "Beta_Academy";
            tabMain.ResumeLayout(false);
            tpManage.ResumeLayout(false);
            tabManage.ResumeLayout(false);
            tpTeacher.ResumeLayout(false);
            grpTeacherList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).EndInit();
            pnlTeacherBtn.ResumeLayout(false);
            grpTeacher.ResumeLayout(false);
            grpTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTeacher).EndInit();
            tpCourse.ResumeLayout(false);
            grpCourseList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            pnlCourseBtn.ResumeLayout(false);
            grpCourse.ResumeLayout(false);
            grpCourse.PerformLayout();
            tpSection.ResumeLayout(false);
            grpSectionList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSection).EndInit();
            pnlSectionBtn.ResumeLayout(false);
            grpSection.ResumeLayout(false);
            grpSection.PerformLayout();
            tpStudent.ResumeLayout(false);
            grpStudentList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            pnlStudentBtn.ResumeLayout(false);
            grpStudentAddr.ResumeLayout(false);
            grpStudentAddr.PerformLayout();
            grpStudent.ResumeLayout(false);
            grpStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            tpEnroll.ResumeLayout(false);
            grpEnrollList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEnroll).EndInit();
            pnlEnrollBtn.ResumeLayout(false);
            grpEnroll.ResumeLayout(false);
            grpEnroll.PerformLayout();
            tpSearch.ResumeLayout(false);
            tabSearch.ResumeLayout(false);
            tpSearchCourse.ResumeLayout(false);
            gbCourseResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSearchCourse).EndInit();
            gbCourseSearch.ResumeLayout(false);
            gbCourseSearch.PerformLayout();
            tpSearchSection.ResumeLayout(false);
            gbSectionResult.ResumeLayout(false);
            gbSectionSearch.ResumeLayout(false);
            gbSectionSearch.PerformLayout();
            tpSearchStudent.ResumeLayout(false);
            gbStudentResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSearchStudent).EndInit();
            gbStudentSearch.ResumeLayout(false);
            gbStudentSearch.PerformLayout();
            tpSearchEnroll.ResumeLayout(false);
            gbEnrollResult.ResumeLayout(false);
            gbEnrollSearch.ResumeLayout(false);
            gbEnrollSearch.PerformLayout();
            tpSearchSuccess.ResumeLayout(false);
            gbSuccessResult.ResumeLayout(false);
            gbSuccessSearch.ResumeLayout(false);
            gbSuccessSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchSection).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSearchStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSearchEnroll).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSearchSuccess).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMain;
        private TabPage tpManage;
        private TabPage tpSearch;
        private TabControl tabManage;
        private TabPage tpTeacher;
        private TabPage tpCourse;
        private TabPage tpSection;
        private TabPage tpStudent;
        private TabPage tpEnroll;
        private GroupBox grpTeacher;
        private Panel pnlTeacherBtn;
        private GroupBox grpTeacherList;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTeacherEmail;
        private TextBox txtTeacherMPhone;
        private TextBox txtTeacherHPhone;
        private TextBox txtTeacherLast;
        private TextBox txtTeacherFirst;
        private TextBox txtTeacherId;
        private PictureBox picTeacher;
        private Button btnTeacherAdd;
        private Button btnTeacherPhoto;
        private Button btnTeacherCancel;
        private Button btnTeacherSave;
        private Button btnTeacherDelete;
        private Button btnTeacherEdit;
        private DataGridView dgvTeacher;
        private GroupBox grpCourseList;
        private DataGridView dgvCourse;
        private Panel pnlCourseBtn;
        private Button btnCourseCancel;
        private Button btnCourseSave;
        private Button btnCourseDelete;
        private Button btnCourseEdit;
        private Button btnCourseAdd;
        private GroupBox grpCourse;
        private TextBox txtCourseHours;
        private TextBox txtCourseFee;
        private TextBox txtCourseDesc;
        private TextBox txtCourseNameEn;
        private TextBox txtCourseNameTh;
        private TextBox txtCourseId;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private GroupBox grpSectionList;
        private DataGridView dgvSection;
        private Panel pnlSectionBtn;
        private Button btnSectionCancel;
        private Button btnSectionSave;
        private Button btnSectionDelete;
        private Button btnSectionEdit;
        private Button btnSectionAdd;
        private GroupBox grpSection;
        private TextBox txtSectionRoom;
        private TextBox txtSectionId;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label20;
        private Label label19;
        private ComboBox cboSectionTeacher;
        private ComboBox cboSectionCourse;
        private Label label21;
        private Label label14;
        private Label label13;
        private RadioButton rdoSectionClosed;
        private RadioButton rdoSectionOpen;
        private DateTimePicker dtpSectionEnd;
        private DateTimePicker dtpSectionStart;
        private GroupBox grpStudentAddr;
        private Label label29;
        private Label label30;
        private Label label31;
        private TextBox txtStudentAddrNo;
        private Label label32;
        private Label label33;
        private Label label35;
        private GroupBox grpStudent;
        private TextBox txtStudentPhone;
        private TextBox txtStudentId;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Panel pnlStudentBtn;
        private Button btnStudentCancel;
        private Button btnStudentSave;
        private Button btnStudentDelete;
        private Button btnStudentEdit;
        private Button btnStudentAdd;
        private TextBox txtStudentSubdistrict;
        private TextBox txtStudentStreet;
        private Button btnStudentPhoto;
        private PictureBox picStudent;
        private TextBox txtStudentLast;
        private TextBox txtStudentFirst;
        private GroupBox grpStudentList;
        private DataGridView dgvStudent;
        private ComboBox cboStudentProvince;
        private TextBox txtStudentZip;
        private TextBox txtStudentDistrict;
        private GroupBox grpEnrollList;
        private DataGridView dgvEnroll;
        private Panel pnlEnrollBtn;
        private Button btnEnrollCancel;
        private Button btnEnrollSave;
        private Button btnEnrollDelete;
        private Button btnEnrollEdit;
        private Button btnEnrollAdd;
        private GroupBox grpEnroll;
        private RadioButton rdoEnrollStudying;
        private DateTimePicker dtpEnrollDate;
        private ComboBox cboEnrollSection;
        private ComboBox cboEnrollStudent;
        private Label label23;
        private Label label24;
        private TextBox txtEnrollId;
        private Label label34;
        private Label label36;
        private Label label37;
        private RadioButton rdoEnrollQuit;
        private RadioButton rdoEnrollDone;
        private TabControl tabSearch;
        private TabPage tpSearchCourse;
        private TabPage tpSearchSection;
        private TabPage tpSearchStudent;
        private TabPage tpSearchEnroll;
        private TabPage tpSearchSuccess;
        private GroupBox gbSuccessSearch;
        private MaskedTextBox txtSuccessCourseId;
        private Label label22;
        private GroupBox gbCourseResult;
        private DataGridView dgvSearchCourse;
        private GroupBox gbCourseSearch;
        private Button btnCourseClear;
        private Button btnCourseSearch;
        private MaskedTextBox txtCourseName;
        private Label label38;
        private GroupBox gbSuccessResult;
        private Button btnSuccessClear;
        private Button btnSuccessSearch;
        private GroupBox gbSectionResult;
        private GroupBox gbSectionSearch;
        private Button btnSectionClear;
        private Button btnSectionSearch;
        private MaskedTextBox txtSectionCourse;
        private Label label39;
        private GroupBox gbStudentResult;
        private PictureBox picSearchStudent;
        private GroupBox gbStudentSearch;
        private Button btnStudentClear;
        private Button btnStudentSearch;
        private MaskedTextBox txtStudentName;
        private Label label40;
        private GroupBox gbEnrollResult;
        private GroupBox gbEnrollSearch;
        private Button btnEnrollClear;
        private Button btnEnrollSearch;
        private MaskedTextBox txtEnrollCourse;
        private Label label41;
        private DataGridView dgvSearchSection;
        private DataGridView dgvSearchStudent;
        private DataGridView dgvSearchEnroll;
        private DataGridView dgvSearchSuccess;
    }
}