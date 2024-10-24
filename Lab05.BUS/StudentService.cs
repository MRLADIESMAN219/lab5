using Lab05.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

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
public List<Student> GetAlviên.");
                }

                context.Students.Remove(studentToRemove);
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    throw new Exception("Lỗi  xóa sinh viên.  thử lại sau.", ex);
                }
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
