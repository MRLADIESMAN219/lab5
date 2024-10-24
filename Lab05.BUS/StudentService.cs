using Lab05.DAL;
using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.BUS
{
    public class StudentService
    {
        public List<Student> GetAll()
        {
            using (var context = new StudentDB())
            {
                return context.Students
                              .Include(s => s.Faculty)
                              .Include(s => s.Major)
                              .ToList();
            }
        }

        public List<Student> GetAllHasNoMajor()
        {
            using (var context = new StudentDB())
            {
                return context.Students
                              .Where(s => s.MajorID == null)
                              .Include(s => s.Faculty)
                              .ToList();
            }
        }

        public List<Student> GetStudentsWithoutMajor(int facultyID)
        {
            using (var context = new StudentDB())
            {
                return context.Students
                              .Where(s => s.FacultyID == facultyID && s.MajorID == null)
                              .ToList();
            }
        }

        public Student FindById(string studentID)
        {
            using (var context = new StudentDB())
            {
                return context.Students.FirstOrDefault(s => s.StudentID == studentID);
            }
        }

        public void InsertUpdate(Student s)
        {
            using (var context = new StudentDB())
            {
                if (s.MajorID == -1)
                {
                    s.MajorID = null;
                }
                context.Students.AddOrUpdate(s);
                context.SaveChanges();
            }
        }

        public void Delete(Student s)
        {
            using (var context = new StudentDB())
            {
                if (s != null)
                {
                    context.Students.Remove(s); // Xóa sinh viên
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Student not found.");
                }
            }
        }
        public List<Major> GetMajorsByFaculty(int facultyID)
        {
            using (var context = new StudentDB())
            {
                return context.Majors
                              .Where(m => m.FacultyID == facultyID)
                              .ToList();
            }
        }

        public void RegisterMajor(string studentID, int majorID)
        {
            using (var context = new StudentDB())
            {
                var student = context.Students.Find(studentID);
                if (student != null)
                {
                    student.MajorID = majorID;
                    context.SaveChanges();
                }
            }
        }
    }
}
