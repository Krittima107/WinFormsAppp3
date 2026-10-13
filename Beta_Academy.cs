using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.IO; // เพิ่มไลบรารีสำหรับแปลงรูปภาพ

namespace WinFormsApp1
{
    public partial class Beta_Academy : Form
    {
        string teacher_id = "";
        string course_id = "";
        string section_id = "";
        string student_id = "";
        string enroll_id = "";
        string action = "";

        public Beta_Academy()
        {
            InitializeComponent();
        }

        private void Beta_Academy_Load(object sender, EventArgs e)
        {
            ShowAllTeacher();
            ShowAllCourse();
            ShowAllSection();
            ShowAllStudent();     // <-- โหลดข้อมูลตารางผู้เรียนตอนเปิดโปรแกรม
            ShowAllEnroll();
            LoadComboBoxData();
            LoadEnrollComboBoxData();
        }

        // =====================================================================
        // ------------------------- ฟังก์ชันแปลงรูปภาพกลาง -------------------------
        // =====================================================================

        private byte[] ImageToByteArray(Image img)
        {
            if (img == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0) return null;
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        // =====================================================================
        // ------------------------- ระบบจัดการผู้สอน (Teacher) -------------------
        // =====================================================================

        private void btnTeacherPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                picTeacher.Image = Image.FromFile(opf.FileName);
            }
        }

        private void ShowAllTeacher()
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            string sql = "SELECT Teacher_ID, Name, H_Phone, M_Phone, email, Photo FROM Teacher ORDER BY Teacher_ID";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTeacher.DataSource = dt;
            conn.Close();

            dgvTeacher.Columns[0].HeaderText = "รหัสผู้สอน";
            dgvTeacher.Columns[1].HeaderText = "ชื่อ-นามสกุล";
            dgvTeacher.Columns[2].HeaderText = "โทรศัพท์ (บ้าน)";
            dgvTeacher.Columns[3].HeaderText = "โทรศัพท์ (มือถือ)";
            dgvTeacher.Columns[4].HeaderText = "อีเมล์";
            dgvTeacher.Columns[5].Visible = false;

            dgvTeacher.RowsDefaultCellStyle.BackColor = Color.Beige;
            dgvTeacher.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvTeacher.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgvTeacher.DefaultCellStyle.Font = new Font("Tahoma", 10);
        }

        private void btnTeacherAdd_Click(object sender, EventArgs e)
        {
            teacher_id = "";
            action = "insert_teacher";

            txtTeacherId.Clear();
            txtTeacherFirst.Clear();
            txtTeacherLast.Clear();
            txtTeacherHPhone.Clear();
            txtTeacherMPhone.Clear();
            txtTeacherEmail.Clear();
            picTeacher.Image = null;

            txtTeacherId.ReadOnly = false;
            txtTeacherId.Focus();
        }

        private void btnTeacherEdit_Click(object sender, EventArgs e)
        {
            if (teacher_id == "" || dgvTeacher.CurrentRow == null)
            {
                MessageBox.Show("กรุณาคลิกเลือกรายชื่อผู้สอนในตารางก่อนกดปุ่มแก้ไขครับ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            action = "update_teacher";
            DataGridViewRow row = dgvTeacher.CurrentRow;

            txtTeacherId.Text = row.Cells[0].Value.ToString();

            string fullName = row.Cells[1].Value.ToString();
            string[] names = fullName.Split(new char[] { ' ' }, 2);
            txtTeacherFirst.Text = names[0];
            if (names.Length > 1) txtTeacherLast.Text = names[1];
            else txtTeacherLast.Text = "";

            txtTeacherHPhone.Text = row.Cells[2].Value.ToString();
            txtTeacherMPhone.Text = row.Cells[3].Value.ToString();
            txtTeacherEmail.Text = row.Cells[4].Value.ToString();

            if (row.Cells[5].Value != DBNull.Value)
            {
                picTeacher.Image = ByteArrayToImage((byte[])row.Cells[5].Value);
            }
            else
            {
                picTeacher.Image = null;
            }

            txtTeacherId.ReadOnly = true;
            txtTeacherFirst.Focus();
        }

        private void btnTeacherCancel_Click(object sender, EventArgs e)
        {
            btnTeacherAdd_Click(sender, e);
            action = "";
        }

        private void dgvTeacher_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            teacher_id = dgvTeacher.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void InsertTeacherRecord()
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            SqlCommand com = new SqlCommand("Insert_Teacher", conn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@id", txtTeacherId.Text);
            com.Parameters.AddWithValue("@name", txtTeacherFirst.Text.Trim() + " " + txtTeacherLast.Text.Trim());
            com.Parameters.AddWithValue("@h_phone", txtTeacherHPhone.Text);
            com.Parameters.AddWithValue("@m_phone", txtTeacherMPhone.Text);
            com.Parameters.AddWithValue("@email", txtTeacherEmail.Text);

            byte[] photoBytes = ImageToByteArray(picTeacher.Image);
            if (photoBytes != null)
                com.Parameters.AddWithValue("@photo", photoBytes);
            else
                com.Parameters.Add("@photo", SqlDbType.Image).Value = DBNull.Value;

            com.Parameters.Add("@returnVal", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            conn.Close();

            int result = (int)com.Parameters["@returnVal"].Value;
            if (result == -1)
            {
                MessageBox.Show("รหัสผู้สอนซ้ำ!");
                txtTeacherId.Focus();
                txtTeacherId.SelectAll();
            }
            else
            {
                MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
                ShowAllTeacher();
                btnTeacherCancel_Click(null, null);
            }
        }

        private void UpdateTeacherRecord()
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            SqlCommand com = new SqlCommand("Update_Teacher", conn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@curr_id", teacher_id);
            com.Parameters.AddWithValue("@id", txtTeacherId.Text);
            com.Parameters.AddWithValue("@name", txtTeacherFirst.Text.Trim() + " " + txtTeacherLast.Text.Trim());
            com.Parameters.AddWithValue("@h_phone", txtTeacherHPhone.Text);
            com.Parameters.AddWithValue("@m_phone", txtTeacherMPhone.Text);
            com.Parameters.AddWithValue("@email", txtTeacherEmail.Text);

            byte[] photoBytes = ImageToByteArray(picTeacher.Image);
            if (photoBytes != null)
                com.Parameters.AddWithValue("@photo", photoBytes);
            else
                com.Parameters.Add("@photo", SqlDbType.Image).Value = DBNull.Value;

            com.Parameters.Add("@returnVal", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            conn.Close();

            int result = (int)com.Parameters["@returnVal"].Value;
            if (result == -1)
            {
                MessageBox.Show("รหัสผู้สอนนี้มีคนใช้แล้ว!");
            }
            else
            {
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                ShowAllTeacher();
                btnTeacherCancel_Click(null, null);
            }
        }

        private void btnTeacherSave_Click(object sender, EventArgs e)
        {
            if (action != "insert_teacher" && action != "update_teacher") return;

            if (txtTeacherId.Text.Trim() == "")
            {
                MessageBox.Show("กรุณากรอกรหัสผู้สอน");
                txtTeacherId.Focus();
                return;
            }

            if (action == "insert_teacher") InsertTeacherRecord();
            else if (action == "update_teacher") UpdateTeacherRecord();
        }

        private void btnTeacherDelete_Click(object sender, EventArgs e)
        {
            if (teacher_id == "")
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบในตารางก่อนครับ");
                return;
            }

            if (MessageBox.Show("ต้องการลบรหัสผู้สอน : " + teacher_id + " ใช่หรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection conn = DBConnect.Beta_Academy_Connect();
                SqlTransaction tr = conn.BeginTransaction();
                try
                {
                    SqlCommand com = new SqlCommand("DELETE FROM Teacher WHERE Teacher_ID = @id", conn, tr);
                    com.Parameters.AddWithValue("@id", teacher_id);
                    com.ExecuteNonQuery();
                    tr.Commit();

                    MessageBox.Show("ลบข้อมูลเรียบร้อย");
                    ShowAllTeacher();
                    btnTeacherCancel_Click(sender, e);
                }
                catch
                {
                    tr.Rollback();
                    MessageBox.Show("ลบไม่สำเร็จ (อาจมีการนำรหัสนี้ไปใช้งานในตารางอื่นแล้ว)");
                }
                conn.Close();
            }
        }

        // =====================================================================
        // ------------------------- ระบบจัดการหลักสูตร (Course) -------------------
        // =====================================================================

        private void ShowAllCourse()
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            string sql = "SELECT Course_ID, Course_Name_th, Course_Name_en, Course_Des, Tuition_Fee, Total_Hours FROM Course ORDER BY Course_ID";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCourse.DataSource = dt;
            conn.Close();

            dgvCourse.Columns[0].HeaderText = "รหัสหลักสูตร";
            dgvCourse.Columns[1].HeaderText = "ชื่อหลักสูตร (ไทย)";
            dgvCourse.Columns[2].HeaderText = "ชื่อหลักสูตร (อังกฤษ)";
            dgvCourse.Columns[3].HeaderText = "รายละเอียด";
            dgvCourse.Columns[4].HeaderText = "ค่าเรียน";
            dgvCourse.Columns[5].HeaderText = "ชั่วโมงเรียน";

            dgvCourse.RowsDefaultCellStyle.BackColor = Color.Beige;
            dgvCourse.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvCourse.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgvCourse.DefaultCellStyle.Font = new Font("Tahoma", 10);
        }

        private void btnCourseAdd_Click(object sender, EventArgs e)
        {
            course_id = "";
            action = "insert_course";

            txtCourseId.Clear();
            txtCourseNameTh.Clear();
            txtCourseNameEn.Clear();
            txtCourseDesc.Clear();
            txtCourseFee.Clear();
            txtCourseHours.Clear();

            txtCourseId.ReadOnly = false;
            txtCourseId.Focus();
        }

        private void btnCourseEdit_Click(object sender, EventArgs e)
        {
            if (course_id == "" || dgvCourse.CurrentRow == null)
            {
                MessageBox.Show("กรุณาคลิกเลือกหลักสูตรในตารางก่อนกดปุ่มแก้ไขครับ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            action = "update_course";
            DataGridViewRow row = dgvCourse.CurrentRow;

            txtCourseId.Text = row.Cells[0].Value.ToString();
            txtCourseNameTh.Text = row.Cells[1].Value.ToString();
            txtCourseNameEn.Text = row.Cells[2].Value.ToString();
            txtCourseDesc.Text = row.Cells[3].Value.ToString();
            txtCourseFee.Text = row.Cells[4].Value.ToString();
            txtCourseHours.Text = row.Cells[5].Value.ToString();

            txtCourseId.ReadOnly = true;
            txtCourseNameTh.Focus();
        }

        private void btnCourseCancel_Click(object sender, EventArgs e)
        {
            btnCourseAdd_Click(sender, e);
            action = "";
        }

        private void dgvCourse_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            course_id = dgvCourse.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void InsertCourseRecord()
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            SqlCommand com = new SqlCommand("Insert_Course", conn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@id", txtCourseId.Text);
            com.Parameters.AddWithValue("@name_th", txtCourseNameTh.Text);
            com.Parameters.AddWithValue("@name_en", txtCourseNameEn.Text);
            com.Parameters.AddWithValue("@desc", txtCourseDesc.Text);
            com.Parameters.AddWithValue("@fee", Convert.ToDecimal(txtCourseFee.Text));
            com.Parameters.AddWithValue("@hours", Convert.ToInt32(txtCourseHours.Text));

            com.Parameters.Add("@returnVal", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            conn.Close();

            int result = (int)com.Parameters["@returnVal"].Value;
            if (result == -1)
            {
                MessageBox.Show("รหัสหลักสูตรซ้ำ!");
                txtCourseId.Focus();
                txtCourseId.SelectAll();
            }
            else
            {
                MessageBox.Show("เพิ่มข้อมูลหลักสูตรสำเร็จ");
                ShowAllCourse();
                btnCourseCancel_Click(null, null);
            }
        }

        private void UpdateCourseRecord()
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            SqlCommand com = new SqlCommand("Update_Course", conn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@curr_id", course_id);
            com.Parameters.AddWithValue("@id", txtCourseId.Text);
            com.Parameters.AddWithValue("@name_th", txtCourseNameTh.Text);
            com.Parameters.AddWithValue("@name_en", txtCourseNameEn.Text);
            com.Parameters.AddWithValue("@desc", txtCourseDesc.Text);
            com.Parameters.AddWithValue("@fee", Convert.ToDecimal(txtCourseFee.Text));
            com.Parameters.AddWithValue("@hours", Convert.ToInt32(txtCourseHours.Text));

            com.Parameters.Add("@returnVal", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            conn.Close();

            int result = (int)com.Parameters["@returnVal"].Value;
            if (result == -1)
            {
                MessageBox.Show("รหัสหลักสูตรนี้มีคนใช้แล้ว!");
            }
            else
            {
                MessageBox.Show("แก้ไขข้อมูลหลักสูตรสำเร็จ");
                ShowAllCourse();
                btnCourseCancel_Click(null, null);
            }
        }

        private void btnCourseSave_Click(object sender, EventArgs e)
        {
            if (action != "insert_course" && action != "update_course") return;

            if (txtCourseId.Text.Trim() == "")
            {
                MessageBox.Show("กรุณากรอกรหัสหลักสูตร");
                txtCourseId.Focus();
                return;
            }

            try { Convert.ToDecimal(txtCourseFee.Text); } catch { MessageBox.Show("ค่าเรียนต้องเป็นตัวเลข"); txtCourseFee.Focus(); return; }
            try { Convert.ToInt32(txtCourseHours.Text); } catch { MessageBox.Show("จำนวนชั่วโมงเรียนต้องเป็นตัวเลข"); txtCourseHours.Focus(); return; }

            if (action == "insert_course") InsertCourseRecord();
            else if (action == "update_course") UpdateCourseRecord();
        }

        private void btnCourseDelete_Click(object sender, EventArgs e)
        {
            if (course_id == "")
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบในตารางก่อนครับ");
                return;
            }

            if (MessageBox.Show("ต้องการลบรหัสหลักสูตร : " + course_id + " ใช่หรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection conn = DBConnect.Beta_Academy_Connect();
                SqlTransaction tr = conn.BeginTransaction();
                try
                {
                    SqlCommand com = new SqlCommand("DELETE FROM Course WHERE Course_ID = @id", conn, tr);
                    com.Parameters.AddWithValue("@id", course_id);
                    com.ExecuteNonQuery();
                    tr.Commit();

                    MessageBox.Show("ลบข้อมูลเรียบร้อย");
                    ShowAllCourse();
                    btnCourseCancel_Click(sender, e);
                }
                catch
                {
                    tr.Rollback();
                    MessageBox.Show("ลบไม่สำเร็จ (อาจมีนักเรียนลงทะเบียนเรียนวิชานี้ หรือมีหมู่เรียนอ้างอิงอยู่)");
                }
                conn.Close();
            }
        }

        // =====================================================================
        // ------------------------- ระบบจัดการหมู่เรียน (Section) ------------------
        // =====================================================================

        private void LoadComboBoxData()
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();

            string sqlCourse = "SELECT Course_ID, Course_Name_th FROM Course";
            SqlDataAdapter daCourse = new SqlDataAdapter(sqlCourse, conn);
            DataTable dtCourse = new DataTable();
            daCourse.Fill(dtCourse);
            cboSectionCourse.DataSource = dtCourse;
            cboSectionCourse.DisplayMember = "Course_Name_th";
            cboSectionCourse.ValueMember = "Course_ID";

            string sqlTeacher = "SELECT Teacher_ID, Name FROM Teacher";
            SqlDataAdapter daTeacher = new SqlDataAdapter(sqlTeacher, conn);
            DataTable dtTeacher = new DataTable();
            daTeacher.Fill(dtTeacher);
            cboSectionTeacher.DataSource = dtTeacher;
            cboSectionTeacher.DisplayMember = "Name";
            cboSectionTeacher.ValueMember = "Teacher_ID";

            conn.Close();
        }

        private void ShowAllSection()
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            string sql = @"SELECT s.Section_ID, c.Course_Name_th, t.Name, s.Status, s.Start_Date, s.End_Date, s.Room 
                           FROM Section s
                           JOIN Course c ON s.Course_ID = c.Course_ID
                           JOIN Teacher t ON s.Teacher_ID = t.Teacher_ID
                           ORDER BY s.Section_ID";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSection.DataSource = dt;
            conn.Close();

            dgvSection.Columns[0].HeaderText = "รหัสหมู่เรียน";
            dgvSection.Columns[1].HeaderText = "หลักสูตร";
            dgvSection.Columns[2].HeaderText = "ผู้สอน";
            dgvSection.Columns[3].HeaderText = "สถานะ";
            dgvSection.Columns[4].HeaderText = "วันที่เริ่มเรียน";
            dgvSection.Columns[5].HeaderText = "วันที่จบหลักสูตร";
            dgvSection.Columns[6].HeaderText = "ห้องเรียน";

            dgvSection.RowsDefaultCellStyle.BackColor = Color.Beige;
            dgvSection.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvSection.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgvSection.DefaultCellStyle.Font = new Font("Tahoma", 10);
        }

        private void btnSectionAdd_Click(object sender, EventArgs e)
        {
            section_id = "";
            action = "insert_section";

            txtSectionId.Clear();
            txtSectionRoom.Clear();
            LoadComboBoxData();

            if (cboSectionCourse.Items.Count > 0) cboSectionCourse.SelectedIndex = 0;
            if (cboSectionTeacher.Items.Count > 0) cboSectionTeacher.SelectedIndex = 0;
            dtpSectionStart.Value = DateTime.Now;
            dtpSectionEnd.Value = DateTime.Now;
            rdoSectionOpen.Checked = true;

            txtSectionId.ReadOnly = false;
            txtSectionId.Focus();
        }

        private void btnSectionEdit_Click(object sender, EventArgs e)
        {
            if (section_id == "" || dgvSection.CurrentRow == null)
            {
                MessageBox.Show("กรุณาคลิกเลือกหมู่เรียนในตารางก่อนกดปุ่มแก้ไขครับ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            action = "update_section";
            DataGridViewRow row = dgvSection.CurrentRow;

            txtSectionId.Text = row.Cells[0].Value.ToString();
            cboSectionCourse.Text = row.Cells[1].Value.ToString();
            cboSectionTeacher.Text = row.Cells[2].Value.ToString();

            string status = row.Cells[3].Value.ToString();
            if (status == "เปิด" || status == "เปิดสอน") rdoSectionOpen.Checked = true;
            else rdoSectionClosed.Checked = true;

            dtpSectionStart.Value = Convert.ToDateTime(row.Cells[4].Value);
            dtpSectionEnd.Value = Convert.ToDateTime(row.Cells[5].Value);
            txtSectionRoom.Text = row.Cells[6].Value.ToString();

            txtSectionId.ReadOnly = true;
            txtSectionRoom.Focus();
        }

        private void btnSectionCancel_Click(object sender, EventArgs e)
        {
            btnSectionAdd_Click(sender, e);
            action = "";
        }

        private void dgvSection_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            section_id = dgvSection.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void InsertSectionRecord()
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            SqlCommand com = new SqlCommand("Insert_Section", conn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@section_id", txtSectionId.Text);
            com.Parameters.AddWithValue("@teacher_id", Convert.ToInt32(cboSectionTeacher.SelectedValue));
            com.Parameters.AddWithValue("@course_id", cboSectionCourse.SelectedValue.ToString());
            com.Parameters.AddWithValue("@status", rdoSectionOpen.Checked ? "เปิดสอน" : "ปิด");
            com.Parameters.AddWithValue("@start_date", dtpSectionStart.Value.ToString("yyyy-MM-dd"));
            com.Parameters.AddWithValue("@end_date", dtpSectionEnd.Value.ToString("yyyy-MM-dd"));
            com.Parameters.AddWithValue("@room", txtSectionRoom.Text);

            com.Parameters.Add("@returnVal", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            conn.Close();

            int result = (int)com.Parameters["@returnVal"].Value;
            if (result == -1)
            {
                MessageBox.Show("รหัสหมู่เรียนซ้ำ!");
                txtSectionId.Focus();
                txtSectionId.SelectAll();
            }
            else
            {
                MessageBox.Show("เพิ่มข้อมูลหมู่เรียนสำเร็จ");
                ShowAllSection();
                btnSectionCancel_Click(null, null);
            }
        }

        private void UpdateSectionRecord()
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            SqlCommand com = new SqlCommand("Update_Section", conn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@curr_id", section_id);
            com.Parameters.AddWithValue("@section_id", txtSectionId.Text);
            com.Parameters.AddWithValue("@teacher_id", Convert.ToInt32(cboSectionTeacher.SelectedValue));
            com.Parameters.AddWithValue("@course_id", cboSectionCourse.SelectedValue.ToString());
            com.Parameters.AddWithValue("@status", rdoSectionOpen.Checked ? "เปิดสอน" : "ปิด");
            com.Parameters.AddWithValue("@start_date", dtpSectionStart.Value.ToString("yyyy-MM-dd"));
            com.Parameters.AddWithValue("@end_date", dtpSectionEnd.Value.ToString("yyyy-MM-dd"));
            com.Parameters.AddWithValue("@room", txtSectionRoom.Text);

            com.Parameters.Add("@returnVal", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            conn.Close();

            int result = (int)com.Parameters["@returnVal"].Value;
            if (result == -1)
            {
                MessageBox.Show("รหัสหมู่เรียนนี้มีคนใช้แล้ว!");
            }
            else
            {
                MessageBox.Show("แก้ไขข้อมูลหมู่เรียนสำเร็จ");
                ShowAllSection();
                btnSectionCancel_Click(null, null);
            }
        }

        private void btnSectionSave_Click(object sender, EventArgs e)
        {
            if (action != "insert_section" && action != "update_section")
            {
                MessageBox.Show("กรุณากดปุ่ม 'เพิ่ม' หรือเลือกรายการในตารางเพื่อ 'แก้ไข' ก่อนบันทึกครับ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSectionId.Text.Trim() == "")
            {
                MessageBox.Show("กรุณากรอกรหัสหมู่เรียน");
                txtSectionId.Focus();
                return;
            }

            if (action == "insert_section") InsertSectionRecord();
            else if (action == "update_section") UpdateSectionRecord();
        }

        private void btnSectionDelete_Click(object sender, EventArgs e)
        {
            if (section_id == "")
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบในตารางก่อนครับ");
                return;
            }

            if (MessageBox.Show("ต้องการลบรหัสหมู่เรียน : " + section_id + " ใช่หรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection conn = DBConnect.Beta_Academy_Connect();
                SqlTransaction tr = conn.BeginTransaction();
                try
                {
                    SqlCommand com = new SqlCommand("DELETE FROM Section WHERE Section_ID = @id", conn, tr);
                    com.Parameters.AddWithValue("@id", section_id);
                    com.ExecuteNonQuery();
                    tr.Commit();

                    MessageBox.Show("ลบข้อมูลเรียบร้อย");
                    ShowAllSection();
                    btnSectionCancel_Click(sender, e);
                }
                catch
                {
                    tr.Rollback();
                    MessageBox.Show("ลบไม่สำเร็จ (อาจมีการนำหมู่เรียนนี้ไปใช้อ้างอิงในการลงทะเบียนเรียนของนักเรียนแล้ว)");
                }
                conn.Close();
            }
        }

        // =====================================================================
        // ------------------------- ระบบจัดการผู้เรียน (Student) -------------------
        // =====================================================================

        private void ShowAllStudent()
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            string sql = "SELECT student_id, student_name, address_no, street, subdistrict, district, province, zipcode, phone, photo FROM Student ORDER BY student_id";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvStudent.DataSource = dt;
            conn.Close();

            dgvStudent.Columns[0].HeaderText = "รหัสผู้เรียน";
            dgvStudent.Columns[1].HeaderText = "ชื่อ-นามสกุล";
            dgvStudent.Columns[2].HeaderText = "บ้านเลขที่";
            dgvStudent.Columns[3].HeaderText = "ถนน";
            dgvStudent.Columns[4].HeaderText = "ตำบล";
            dgvStudent.Columns[5].HeaderText = "อำเภอ";
            dgvStudent.Columns[6].HeaderText = "จังหวัด";
            dgvStudent.Columns[7].HeaderText = "รหัสไปรษณีย์";
            dgvStudent.Columns[8].HeaderText = "เบอร์โทรศัพท์";
            dgvStudent.Columns[9].Visible = false; // ซ่อนคอลัมน์รูปภาพ

            dgvStudent.RowsDefaultCellStyle.BackColor = Color.Beige;
            dgvStudent.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvStudent.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgvStudent.DefaultCellStyle.Font = new Font("Tahoma", 10);
        }

        private void btnStudentPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                picStudent.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            student_id = "";
            action = "insert_student";

            txtStudentId.Clear();
            txtStudentFirst.Clear();
            txtStudentLast.Clear();
            txtStudentPhone.Clear();
            txtStudentAddrNo.Clear();
            txtStudentStreet.Clear();
            txtStudentSubdistrict.Clear();
            txtStudentDistrict.Clear();
            txtStudentZip.Clear();
            cboStudentProvince.Clear(); // แก้จากเดิมเป็นเคลียร์ข้อความของ TextBox
            picStudent.Image = null;

            txtStudentId.ReadOnly = false;
            txtStudentId.Focus();
        }

        private void btnStudentEdit_Click(object sender, EventArgs e)
        {
            if (student_id == "" || dgvStudent.CurrentRow == null)
            {
                MessageBox.Show("กรุณาคลิกเลือกรายชื่อผู้เรียนในตารางก่อนกดปุ่มแก้ไขครับ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            action = "update_student";
            DataGridViewRow row = dgvStudent.CurrentRow;

            txtStudentId.Text = row.Cells[0].Value.ToString();

            string fullName = row.Cells[1].Value.ToString();
            string[] names = fullName.Split(new char[] { ' ' }, 2);
            txtStudentFirst.Text = names[0];
            if (names.Length > 1) txtStudentLast.Text = names[1];
            else txtStudentLast.Text = "";

            txtStudentAddrNo.Text = row.Cells[2].Value.ToString();
            txtStudentStreet.Text = row.Cells[3].Value.ToString();
            txtStudentSubdistrict.Text = row.Cells[4].Value.ToString();
            txtStudentDistrict.Text = row.Cells[5].Value.ToString();
            cboStudentProvince.Text = row.Cells[6].Value.ToString();
            txtStudentZip.Text = row.Cells[7].Value.ToString();
            txtStudentPhone.Text = row.Cells[8].Value.ToString();

            if (row.Cells[9].Value != DBNull.Value && !string.IsNullOrEmpty(row.Cells[9].Value.ToString()))
            {
                try { picStudent.Image = ByteArrayToImage((byte[])row.Cells[9].Value); }
                catch { picStudent.Image = null; }
            }
            else
            {
                picStudent.Image = null;
            }

            txtStudentId.ReadOnly = true;
            txtStudentFirst.Focus();
        }

        private void btnStudentCancel_Click(object sender, EventArgs e)
        {
            btnStudentAdd_Click(sender, e);
            action = "";
        }

        private void dgvStudent_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            student_id = dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void InsertStudentRecord()
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            SqlCommand com = new SqlCommand("Insert_Student", conn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@student_id", txtStudentId.Text);
            com.Parameters.AddWithValue("@student_name", txtStudentFirst.Text.Trim() + " " + txtStudentLast.Text.Trim());
            com.Parameters.AddWithValue("@address_no", txtStudentAddrNo.Text);
            com.Parameters.AddWithValue("@street", txtStudentStreet.Text);
            com.Parameters.AddWithValue("@subdistrict", txtStudentSubdistrict.Text);
            com.Parameters.AddWithValue("@district", txtStudentDistrict.Text);
            com.Parameters.AddWithValue("@province", cboStudentProvince.Text);
            com.Parameters.AddWithValue("@zipcode", txtStudentZip.Text);
            com.Parameters.AddWithValue("@phone", txtStudentPhone.Text);

            // จัดการรูปภาพ (แปลงเป็นไบต์ก่อนบันทึก)
            byte[] photoBytes = ImageToByteArray(picStudent.Image);
            if (photoBytes != null)
                com.Parameters.AddWithValue("@photo", photoBytes);
            else
                com.Parameters.Add("@photo", SqlDbType.Image).Value = DBNull.Value;

            com.Parameters.Add("@returnVal", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            conn.Close();

            int result = (int)com.Parameters["@returnVal"].Value;
            if (result == -1)
            {
                MessageBox.Show("รหัสผู้เรียนซ้ำ!");
                txtStudentId.Focus();
                txtStudentId.SelectAll();
            }
            else
            {
                MessageBox.Show("เพิ่มข้อมูลผู้เรียนสำเร็จ");
                ShowAllStudent();
                btnStudentCancel_Click(null, null);
            }
        }

        private void UpdateStudentRecord()
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            SqlCommand com = new SqlCommand("Update_Student", conn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@curr_id", student_id);
            com.Parameters.AddWithValue("@student_id", txtStudentId.Text);
            com.Parameters.AddWithValue("@student_name", txtStudentFirst.Text.Trim() + " " + txtStudentLast.Text.Trim());
            com.Parameters.AddWithValue("@address_no", txtStudentAddrNo.Text);
            com.Parameters.AddWithValue("@street", txtStudentStreet.Text);
            com.Parameters.AddWithValue("@subdistrict", txtStudentSubdistrict.Text);
            com.Parameters.AddWithValue("@district", txtStudentDistrict.Text);
            com.Parameters.AddWithValue("@province", cboStudentProvince.Text);
            com.Parameters.AddWithValue("@zipcode", txtStudentZip.Text);
            com.Parameters.AddWithValue("@phone", txtStudentPhone.Text);

            // จัดการรูปภาพตอนอัพเดท
            byte[] photoBytes = ImageToByteArray(picStudent.Image);
            if (photoBytes != null)
                com.Parameters.AddWithValue("@photo", photoBytes);
            else
                com.Parameters.Add("@photo", SqlDbType.Image).Value = DBNull.Value;

            com.Parameters.Add("@returnVal", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            conn.Close();

            int result = (int)com.Parameters["@returnVal"].Value;
            if (result == -1)
            {
                MessageBox.Show("รหัสผู้เรียนนี้มีคนใช้แล้ว!");
            }
            else
            {
                MessageBox.Show("แก้ไขข้อมูลผู้เรียนสำเร็จ");
                ShowAllStudent();
                btnStudentCancel_Click(null, null);
            }
        }

        private void btnStudentSave_Click(object sender, EventArgs e)
        {
            if (action != "insert_student" && action != "update_student")
            {
                MessageBox.Show("กรุณากดปุ่ม 'เพิ่ม' หรือเลือกรายการในตารางเพื่อ 'แก้ไข' ก่อนบันทึกครับ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtStudentId.Text.Trim() == "")
            {
                MessageBox.Show("กรุณากรอกรหัสผู้เรียน");
                txtStudentId.Focus();
                return;
            }

            if (action == "insert_student") InsertStudentRecord();
            else if (action == "update_student") UpdateStudentRecord();
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            if (student_id == "")
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบในตารางก่อนครับ");
                return;
            }

            if (MessageBox.Show("ต้องการลบรหัสผู้เรียน : " + student_id + " ใช่หรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection conn = DBConnect.Beta_Academy_Connect();
                SqlTransaction tr = conn.BeginTransaction();
                try
                {
                    SqlCommand com = new SqlCommand("DELETE FROM Student WHERE student_id = @id", conn, tr);
                    com.Parameters.AddWithValue("@id", student_id);
                    com.ExecuteNonQuery();
                    tr.Commit();

                    MessageBox.Show("ลบข้อมูลผู้เรียนเรียบร้อย");
                    ShowAllStudent();
                    btnStudentCancel_Click(sender, e);
                }
                catch
                {
                    tr.Rollback();
                    MessageBox.Show("ลบไม่สำเร็จ (อาจมีการนำรหัสผู้เรียนนี้ไปอ้างอิงในการลงทะเบียนเรียนแล้ว)");
                }
                conn.Close();
            }
        }

        private void cboStudentProvince_TextChanged(object sender, EventArgs e)
        {

        }


        private void LoadEnrollComboBoxData()
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();

            // โหลดรายชื่อผู้เรียนใส่ ComboBox
            string sqlStudent = "SELECT student_id, student_name FROM Student";
            SqlDataAdapter daStudent = new SqlDataAdapter(sqlStudent, conn);
            DataTable dtStudent = new DataTable();
            daStudent.Fill(dtStudent);
            cboEnrollStudent.DataSource = dtStudent;
            cboEnrollStudent.DisplayMember = "student_name";
            cboEnrollStudent.ValueMember = "student_id";

            // โหลดรหัสหมู่เรียนใส่ ComboBox
            string sqlSection = "SELECT Section_ID FROM Section";
            SqlDataAdapter daSection = new SqlDataAdapter(sqlSection, conn);
            DataTable dtSection = new DataTable();
            daSection.Fill(dtSection);
            cboEnrollSection.DataSource = dtSection;
            cboEnrollSection.DisplayMember = "Section_ID";
            cboEnrollSection.ValueMember = "Section_ID";

            conn.Close();
        }

        private void ShowAllEnroll()
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            string sql = @"SELECT e.enroll_id, s.student_name, e.section_id, e.study_status, e.enroll_data 
                   FROM Enroll e
                   JOIN Student s ON e.student_id = s.student_id
                   ORDER BY e.enroll_id";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEnroll.DataSource = dt;
            conn.Close();

            dgvEnroll.Columns[0].HeaderText = "รหัสการลงทะเบียน";
            dgvEnroll.Columns[1].HeaderText = "ชื่อผู้เรียน";
            dgvEnroll.Columns[2].HeaderText = "รหัสหมู่เรียน";
            dgvEnroll.Columns[3].HeaderText = "สถานะการเรียน";
            dgvEnroll.Columns[4].HeaderText = "วันที่ลงทะเบียน";

            dgvEnroll.RowsDefaultCellStyle.BackColor = Color.Beige;
            dgvEnroll.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvEnroll.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgvEnroll.DefaultCellStyle.Font = new Font("Tahoma", 10);
        }

        private void btnEnrollAdd_Click(object sender, EventArgs e)
        {
            enroll_id = "";
            action = "insert_enroll";

            txtEnrollId.Clear();
            LoadEnrollComboBoxData();

            if (cboEnrollStudent.Items.Count > 0) cboEnrollStudent.SelectedIndex = 0;
            if (cboEnrollSection.Items.Count > 0) cboEnrollSection.SelectedIndex = 0;
            dtpEnrollDate.Value = DateTime.Now;
            rdoEnrollStudying.Checked = true;

            txtEnrollId.ReadOnly = false;
            txtEnrollId.Focus();
        }

        private void btnEnrollEdit_Click(object sender, EventArgs e)
        {
            if (enroll_id == "" || dgvEnroll.CurrentRow == null)
            {
                MessageBox.Show("กรุณาคลิกเลือกรายการลงทะเบียนในตารางก่อนกดปุ่มแก้ไขครับ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            action = "update_enroll";
            DataGridViewRow row = dgvEnroll.CurrentRow;

            txtEnrollId.Text = row.Cells[0].Value.ToString();
            cboEnrollStudent.Text = row.Cells[1].Value.ToString();
            cboEnrollSection.Text = row.Cells[2].Value.ToString();

            string status = row.Cells[3].Value.ToString();
            if (status == "กำลังเรียน") rdoEnrollStudying.Checked = true;
            else if (status == "สำเร็จ") rdoEnrollDone.Checked = true;
            else rdoEnrollQuit.Checked = true;

            dtpEnrollDate.Value = Convert.ToDateTime(row.Cells[4].Value);

            txtEnrollId.ReadOnly = true;
            cboEnrollStudent.Focus();
        }

        private void btnEnrollCancel_Click(object sender, EventArgs e)
        {
            btnEnrollAdd_Click(sender, e);
            action = "";
        }

        private void dgvEnroll_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            enroll_id = dgvEnroll.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void InsertEnrollRecord()
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            SqlCommand com = new SqlCommand("Insert_Enroll", conn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@enroll_id", txtEnrollId.Text);
            com.Parameters.AddWithValue("@student_id", cboEnrollStudent.SelectedValue.ToString());
            com.Parameters.AddWithValue("@section_id", cboEnrollSection.SelectedValue.ToString());

            string status = "กำลังเรียน";
            if (rdoEnrollDone.Checked) status = "สำเร็จ";
            else if (rdoEnrollQuit.Checked) status = "เลิกเรียน";
            com.Parameters.AddWithValue("@study_status", status);

            com.Parameters.AddWithValue("@enroll_data", dtpEnrollDate.Value.ToString("yyyy-MM-dd"));

            com.Parameters.Add("@returnVal", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            conn.Close();

            int result = (int)com.Parameters["@returnVal"].Value;
            if (result == -1)
            {
                MessageBox.Show("รหัสการลงทะเบียนซ้ำ!");
                txtEnrollId.Focus();
                txtEnrollId.SelectAll();
            }
            else
            {
                MessageBox.Show("เพิ่มข้อมูลการลงทะเบียนสำเร็จ");
                ShowAllEnroll();
                btnEnrollCancel_Click(null, null);
            }
        }

        private void UpdateEnrollRecord()
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            SqlCommand com = new SqlCommand("Update_Enroll", conn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@curr_id", enroll_id);
            com.Parameters.AddWithValue("@enroll_id", txtEnrollId.Text);
            com.Parameters.AddWithValue("@student_id", cboEnrollStudent.SelectedValue.ToString());
            com.Parameters.AddWithValue("@section_id", cboEnrollSection.SelectedValue.ToString());

            string status = "กำลังเรียน";
            if (rdoEnrollDone.Checked) status = "สำเร็จ";
            else if (rdoEnrollQuit.Checked) status = "เลิกเรียน";
            com.Parameters.AddWithValue("@study_status", status);

            com.Parameters.AddWithValue("@enroll_data", dtpEnrollDate.Value.ToString("yyyy-MM-dd"));

            com.Parameters.Add("@returnVal", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            conn.Close();

            int result = (int)com.Parameters["@returnVal"].Value;
            if (result == -1)
            {
                MessageBox.Show("รหัสการลงทะเบียนนี้มีคนใช้แล้ว!");
            }
            else
            {
                MessageBox.Show("แก้ไขข้อมูลการลงทะเบียนสำเร็จ");
                ShowAllEnroll();
                btnEnrollCancel_Click(null, null);
            }
        }

        private void btnEnrollSave_Click(object sender, EventArgs e)
        {
            if (action != "insert_enroll" && action != "update_enroll")
            {
                MessageBox.Show("กรุณากดปุ่ม 'เพิ่ม' หรือเลือกรายการในตารางเพื่อ 'แก้ไข' ก่อนบันทึกครับ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtEnrollId.Text.Trim() == "")
            {
                MessageBox.Show("กรุณากรอกรหัสการลงทะเบียน");
                txtEnrollId.Focus();
                return;
            }

            if (action == "insert_enroll") InsertEnrollRecord();
            else if (action == "update_enroll") UpdateEnrollRecord();
        }

        private void btnEnrollDelete_Click(object sender, EventArgs e)
        {
            if (enroll_id == "")
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบในตารางก่อนครับ");
                return;
            }

            if (MessageBox.Show("ต้องการลบรหัสการลงทะเบียน : " + enroll_id + " ใช่หรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection conn = DBConnect.Beta_Academy_Connect();
                SqlTransaction tr = conn.BeginTransaction();
                try
                {
                    SqlCommand com = new SqlCommand("DELETE FROM Enroll WHERE enroll_id = @id", conn, tr);
                    com.Parameters.AddWithValue("@id", enroll_id);
                    com.ExecuteNonQuery();
                    tr.Commit();

                    MessageBox.Show("ลบข้อมูลการลงทะเบียนเรียบร้อย");
                    ShowAllEnroll();
                    btnEnrollCancel_Click(sender, e);
                }
                catch
                {
                    tr.Rollback();
                    MessageBox.Show("ลบไม่สำเร็จ");
                }
                conn.Close();
            }
        }


        // ---------------- 1. ค้นหาหลักสูตร (ข้อ 6) ----------------
        private void btnCourseSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            // ค้นหาจากชื่อหลักสูตร (ตามข้อ 6)
            string sql = @"SELECT Course_ID AS [รหัสหลักสูตร], Course_Name_th AS [ชื่อหลักสูตร (ไทย)], 
                          Course_Name_en AS [ชื่อหลักสูตร (อังกฤษ)], Course_Des AS [รายละเอียด], 
                          Tuition_Fee AS [ค่าเรียน], Total_Hours AS [ชั่วโมง] 
                   FROM Course 
                   WHERE Course_Name_th LIKE @name";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", "%" + txtCourseName.Text.Trim() + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSearchCourse.DataSource = dt;
            conn.Close();
            FormatSearchGrid(dgvSearchCourse);
        }

        private void btnCourseClear_Click(object sender, EventArgs e)
        {
            txtCourseName.Clear();
            dgvSearchCourse.DataSource = null;
            txtCourseName.Focus();
        }

        // ---------------- 2. ค้นหาหมู่เรียน (ข้อ 7) ----------------
        private void btnSectionSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            // ค้นหาจากชื่อหลักสูตร (ตามข้อ 7)
            string sql = @"SELECT s.Section_ID AS [รหัสหมู่เรียน], c.Course_Name_th AS [ชื่อหลักสูตร], 
                          t.Name AS [ชื่อผู้สอน], s.Status AS [สถานะหมู่เรียน], 
                          s.Start_Date AS [วันที่เริ่มเรียน], s.End_Date AS [วันที่จบหลักสูตร], s.Room AS [ห้องเรียน]
                   FROM Section s
                   JOIN Course c ON s.Course_ID = c.Course_ID
                   JOIN Teacher t ON s.Teacher_ID = t.Teacher_ID
                   WHERE c.Course_Name_th LIKE @name";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", "%" + txtSectionCourse.Text.Trim() + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSearchSection.DataSource = dt;
            conn.Close();
            FormatSearchGrid(dgvSearchSection);
        }

        private void btnSectionClear_Click(object sender, EventArgs e)
        {
            txtSectionCourse.Clear();
            dgvSearchSection.DataSource = null;
            txtSectionCourse.Focus();
        }

        // ---------------- 3. ค้นหาผู้เรียน (ข้อ 8) ----------------
        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            // ค้นหาจากชื่อผู้เรียน (ตามข้อ 8) ดึงรูปมาด้วยแต่ซ่อนไว้
            string sql = @"SELECT student_id AS [รหัสผู้เรียน], student_name AS [ชื่อ-นามสกุล], 
                          phone AS [เบอร์โทรศัพท์], photo
                   FROM Student
                   WHERE student_name LIKE @name";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", "%" + txtStudentName.Text.Trim() + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSearchStudent.DataSource = dt;
            conn.Close();
            FormatSearchGrid(dgvSearchStudent);

            // ซ่อนคอลัมน์รูปภาพ
            if (dgvSearchStudent.Columns.Count > 3)
                dgvSearchStudent.Columns[3].Visible = false;

            picSearchStudent.Image = null; // เคลียร์รูปเก่า
        }

        private void btnStudentClear_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            dgvSearchStudent.DataSource = null;
            picSearchStudent.Image = null;
            txtStudentName.Focus();
        }

        // Event คลิกตารางแล้วโชว์รูปผู้เรียน
        private void dgvSearchStudent_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvSearchStudent.Rows[e.RowIndex];

            if (row.Cells[3].Value != DBNull.Value && !string.IsNullOrEmpty(row.Cells[3].Value.ToString()))
            {
                try { picSearchStudent.Image = ByteArrayToImage((byte[])row.Cells[3].Value); }
                catch { picSearchStudent.Image = null; }
            }
            else
            {
                picSearchStudent.Image = null;
            }
        }

        // ---------------- 4. ค้นหาผู้ลงทะเบียนในแต่ละหลักสูตร (ข้อ 9) ----------------
        private void btnEnrollSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            // ค้นหาจากชื่อหลักสูตร (ตามข้อ 9)
            string sql = @"SELECT e.enroll_id AS [รหัสการลงทะเบียน], st.student_id AS [รหัสผู้เรียน], 
                          st.student_name AS [ชื่อผู้เรียน], c.Course_Name_th AS [ชื่อหลักสูตร], 
                          s.Section_ID AS [รหัสหมู่เรียน], e.study_status AS [สถานะการเรียน]
                   FROM Enroll e
                   JOIN Student st ON e.student_id = st.student_id
                   JOIN Section s ON e.section_id = s.Section_ID
                   JOIN Course c ON s.Course_ID = c.Course_ID
                   WHERE c.Course_Name_th LIKE @name";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", "%" + txtEnrollCourse.Text.Trim() + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSearchEnroll.DataSource = dt;
            conn.Close();
            FormatSearchGrid(dgvSearchEnroll);
        }

        private void btnEnrollClear_Click(object sender, EventArgs e)
        {
            txtEnrollCourse.Clear();
            dgvSearchEnroll.DataSource = null;
            txtEnrollCourse.Focus();
        }

        // ---------------- 5. ค้นหาผู้เรียนที่สำเร็จในหลักสูตร (ข้อ 10) ----------------
        private void btnSuccessSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnect.Beta_Academy_Connect();
            // ค้นหาจากรหัสหลักสูตร เฉพาะคนที่สำเร็จ (ตามข้อ 10)
            string sql = @"SELECT st.student_id AS [รหัสผู้เรียน], st.student_name AS [ชื่อผู้เรียน], 
                          c.Course_Name_th AS [ชื่อหลักสูตร], e.study_status AS [สถานะการเรียน]
                   FROM Enroll e
                   JOIN Student st ON e.student_id = st.student_id
                   JOIN Section s ON e.section_id = s.Section_ID
                   JOIN Course c ON s.Course_ID = c.Course_ID
                   WHERE c.Course_ID = @id AND e.study_status = N'สำเร็จ'";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", txtSuccessCourseId.Text.Trim()); // ข้อนี้ค้นด้วยรหัส ตรงตัวไม่ต้องใส่ %

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSearchSuccess.DataSource = dt;
            conn.Close();
            FormatSearchGrid(dgvSearchSuccess);
        }

        private void btnSuccessClear_Click(object sender, EventArgs e)
        {
            txtSuccessCourseId.Clear();
            dgvSearchSuccess.DataSource = null;
            txtSuccessCourseId.Focus();
        }

        // ---------------- ฟังก์ชันตกแต่งตารางผลการค้นหา ----------------
        private void FormatSearchGrid(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.Beige;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgv.ClearSelection();
        }

    }
}