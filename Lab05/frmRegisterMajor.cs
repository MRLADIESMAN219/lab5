using Lab05.BUS;
using Lab05.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class frmRegisterMajor : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private readonly MajorService majorService = new MajorService();
        public frmRegisterMajor()
        {
            InitializeComponent();
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
            this.btnRegisterMajor.Click += new System.EventHandler(this.btnRegisterMajor_Click);
        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Faculty selectedFaculty = cmbFaculty.SelectedItem as Faculty;
            if (selectedFaculty != null)
            {
                var listMajor = majorService.GetAllByFaculty(selectedFaculty.FacultyID);
                FillMajorCombobox(listMajor);  

                var listStudents = studentService.GetAllHasNoMajor(selectedFaculty.FacultyID);
                BindGrid(listStudents);
            }
        }
        private void FillMajorCombobox(List<Major> listMajors)
        {
            cmbMajor.DataSource = listMajors;
            cmbMajor.DisplayMember = "Name";  
            cmbMajor.ValueMember = "MajorID"; 
        }
        private void BindGrid(List<Student> listStudents)
        {
            dgvInformationStudentRegister.Rows.Clear(); 

            foreach (var student in listStudents)
            {
                int index = dgvInformationStudentRegister.Rows.Add();

                dgvInformationStudentRegister.Rows[index].Cells["dgvIdStudent"].Value = student.StudentID;
                dgvInformationStudentRegister.Rows[index].Cells[2].Value = student.FullName;

                dgvInformationStudentRegister.Rows[index].Cells[3].Value =
                    student.Faculty != null ? student.Faculty.FacultyName : "Chưa có";

                dgvInformationStudentRegister.Rows[index].Cells[4].Value =
                    student.AverageScore.ToString("0.00");
            }
        }

        private void btnRegisterMajor_Click(object sender, EventArgs e)
        {
            if (cmbMajor.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn chuyên ngành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedMajorID = (int)cmbMajor.SelectedValue;

            foreach (DataGridViewRow row in dgvInformationStudentRegister.Rows)
            {
                bool isChecked = row.Cells["dgvChoose"].Value is bool value && value;

                if (isChecked)
                {
                    string studentID = row.Cells["dgvIdStudent"].Value?.ToString();
                    if (!string.IsNullOrEmpty(studentID))
                    {
                        try
                        {
                            studentService.RegisterMajor(studentID, selectedMajorID);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi đăng ký cho sinh viên {studentID}: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            MessageBox.Show("Đăng ký chuyên ngành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int selectedFacultyID = (int)cmbFaculty.SelectedValue;
            BindGrid(studentService.GetStudentsWithoutMajor(selectedFacultyID));
        }
        private void FillFacultyCombobox(List<Faculty> listFaculties)
        {
            if (listFaculties == null || listFaculties.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu khoa để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbFaculty.DataSource = null;  
                return;
            }

            cmbFaculty.DataSource = listFaculties;
            cmbFaculty.DisplayMember = "FacultyName";
            cmbFaculty.ValueMember = "FacultyID";
        }

        private void frmRegisterMajor_Load(object sender, EventArgs e)
        {
            try
            {
                var listFaculties = facultyService.GetAll();
                FillFacultyCombobox(listFaculties);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
