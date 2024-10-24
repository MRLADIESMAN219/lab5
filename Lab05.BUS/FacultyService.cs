using Lab05.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.BUS
{
    public class FacultyService
    {
        public List<Faculty> GetAll()
        {
            using (var context = new StudentDB())
            {
                return context.Faculties.ToList();
            }
        }
    }
}
