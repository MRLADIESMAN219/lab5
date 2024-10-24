using Lab05.BUS;
using Lab05.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab05
{
    public partial class frmStudent : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        public frmStudent()
        {

            InitializeComponent();

            this.chkUnregisterMajor.CheckedChanged += new EventHandler(chkUnregisterMajor_CheckedChanged);
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dgvInformationStudent);

                var listFacultys = facultyService.GetAll();
                List<Student> listStudents = studentService.GetAll();

                FillFacultyCombobox(listFacultys);
                BindGrid(listStudents);

                dgvInformationStudent.CellClick += dgvInformationStudent_CellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillFacultyCombobox(List<Faculty> listFacultys)
        {
            listFacultys.Insert(0, new Faculty()); 
            this.cmbFaculty.DataSource = listFacultys;
            this.cmbFaculty.DisplayMember = "FacultyName"; 
            this.cmbFaculty.ValueMember = "FacultyID";
        }

        private void BindGrid(List<Student> listStudent)
        {
            dgvInformationStudent.Rows.Clear(); 
            foreach (var item in listStudent)
            {
                int index = dgvInformationStudent.Rows.Add();
                dgvInformationStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvInformationStudent.Rows[index].Cells[1].Value = item.FullName;
                dgvInformationStudent.Rows[index].Cells[2].Value = item.Faculty?.FacultyName ?? "Chưa có khoa"; 
                dgvInformationStudent.Rows[index].Cells[3].Value = item.AverageScore.ToString();
                dgvInformationStudent.Rows[index].Cells[4].Value = item.Major?.Name ?? "Chưa có chuyên ngành"; 
            }
        }

        private void ShowAvatar(string imageName)
        {
            if (string.IsNullOrEmpty(imageName))
            {
                picAvatar.Image = null;
            }
            else
            {
                string imagePath = Path.Combine(Application.StartupPath, "Images", imageName);

                if (File.Exists(imagePath))
                {
                    picAvatar.Image = Image.FromFile(imagePath);
                    picAvatar.Refresh();
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy ảnh: {imagePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    picAvatar.Image = null;
                }
            }
        }
        private bool ValidateStudentInfo()
        {
            err.Clear();

            if (string.IsNullOrWhiteSpace(txtIdStudent.Text) ||
            string.IsNullOrWhiteSpace(txtNameStudent.Text) ||
            string.IsNullOrWhiteSpace(txtAvgScore.Text) ||
            cmbFaculty.SelectedItem == null)
            {
                if (string.IsNullOrWhiteSpace(txtIdStudent.Text))
                    err.SetError(txtIdStudent, "Vui lòng nhập Mã số sinh viên!");
                if (string.IsNullOrWhiteSpace(txtNameStudent.Text))
                    err.SetError(txtNameStudent, "Vui lòng nhập Tên sinh viên!");
                if (string.IsNullOrWhiteSpace(txtAvgScore.Text))
                    err.SetError(txtAvgScore, "Vui lòng nhập Điểm trung bình!");
                if (cmbFaculty.SelectedItem == null)
                    err.SetError(cmbFaculty, "Vui lòng chọn Khoa!");


                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtIdStudent.Text, @"^\d"))
            {
                err.SetError(txtIdStudent, "Mã số sinh viên không hợp lệ. ");
                MessageBox.Show("Mã số sinh viên không hợp lệ. .", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNameStudent.Text, @"^[\p{L}\s]{3,100}$"))
            {
                err.SetError(txtNameStudent, "Tên sinh viên không hợp lệ. Tên phải là chuỗi chữ cái có độ dài từ 3 đến 100 ký tự.");
                MessageBox.Show("Tên sinh viên không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txtAvgScore.Text, out decimal avgScore) || avgScore < 0 || avgScore > 10)
            {
                err.SetError(txtAvgScore, "Điểm trung bình phải là số thập phân từ 0 đến 10.");
                MessageBox.Show("Điểm trung bình sinh viên không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; 
        }
        private void LoadStudentData()
        {
            try
            {
                List<Student> listStudents = studentService.GetAll(); 

                if (listStudents.Count == 0)
                {
                    MessageBox.Show("Không có sinh viên nào trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK);
                }

                foreach (var student in listStudents)
                {
                    Console.WriteLine($"Mã số: {student.StudentID}, Tên: {student.FullName}, Điểm: {student.AverageScore}");
                }

                BindGrid(listStudents); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu sinh viên: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void chkUnregisterMajor_CheckedChanged(object sender, EventArgs e)
        {
            List<Student> listStudents;

            if (this.chkUnregisterMajor.Checked)
            {
                listStudents = studentService.GetAllHasNoMajor();
            }
            else
            {
                listStudents = studentService.GetAll();
            }

            BindGrid(listStudents);
        }

        private void btnAddOrUpdateStudent_Click(object sender, EventArgs e)
        {
            if (!ValidateStudentInfo()) return;

            var student = new Student
            {
                StudentID = txtIdStudent.Text,
                FullName = txtNameStudent.Text,
                AverageScore = double.Parse(txtAvgScore.Text),
                FacultyID = (int)cmbFaculty.SelectedValue,
                MajorID = null
            };

            if (!string.IsNullOrEmpty(avatarFilePath))
            {
                string folderPath = Path.Combine(Application.StartupPath, "Images");
                Directory.CreateDirectory(folderPath);

                string fileName = $"{student.StudentID}{Path.GetExtension(avatarFilePath)}";
                string destinationPath = Path.Combine(folderPath, fileName);

                File.Copy(avatarFilePath, destinationPath, true);
                student.Avatar = fileName;
            }

            try
            {
                studentService.InsertUpdate(student);
                MessageBox.Show("Sinh viên đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsNumeric(string value)
        {
            return double.TryParse(value, out _);
        }

        private bool IsValidStudentName(string value)
        {
            return !value.Any(ch => !char.IsLetter(ch) && !char.IsWhiteSpace(ch));
        }
        public void DeleteStudent(string studentId)
        {
            using (var context = new StudentDB())
            {
                var studentToRemove = context.Students.FirstOrDefault(s => s.StudentID == studentId);
                if (studentToRemove != null)
                {
                    context.Students.Remove(studentToRemove);
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (DbUpdateException ex)
                    {
                        throw new Exception("Lỗi xóa sinh viên", ex);
                    }
                }
                else
                {
                    throw new Exception("Sinh viên không tồn tại");
                }
            }
        }
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdStudent.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sinh viên này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    studentService.DeleteStudent(txtIdStudent.Text);
                    MessageBox.Show("Sinh viên đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentData(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sinh viên chưa được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnexits_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private string avatarFilePath = string.Empty;

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    avatarFilePath = openFileDialog.FileName; 

                    picAvatar.Image = Image.FromFile(avatarFilePath);
                    picAvatar.Refresh();
                }
            }
        }

        private void dgvInformationStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow selectedRow = dgvInformationStudent.Rows[e.RowIndex];

                string studentID = selectedRow.Cells[0].Value.ToString();
                var student = studentService.FindById(studentID); 

                if (student != null)
                {
                    txtIdStudent.Text = student.StudentID;
                    txtNameStudent.Text = student.FullName;
                    txtAvgScore.Text = student.AverageScore.ToString();

                    var facultyExists = cmbFaculty.Items.Cast<Faculty>()
                                          .Any(f => f.FacultyID == student.FacultyID);

                    if (facultyExists && student.FacultyID != null)
                    {
                        cmbFaculty.SelectedValue = student.FacultyID;
                    }
                    else
                    {
                        cmbFaculty.SelectedIndex = 0; 
                    }

                    ShowAvatar(student.Avatar);
                }
            }
        }

        private void toolStripRegisterMajor_Click(object sender, EventArgs e)
        {
            frmRegisterMajor registerForm = new frmRegisterMajor();
            registerForm.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
