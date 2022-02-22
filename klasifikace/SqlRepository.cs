using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasifikace
{
    public class SqlRepository
    {
        private List<Student> TempStudents()
        {
            List<Student> students = new List<Student>();
            var student = new Student()
            {
                Id = 1,
                Firstname = "Pepa",
                Lastname = "Zdepa",
                Birthday = DateTime.Parse("1.1.2000"),
                Grades = new List<Grade>(),
            };
            return students;
        }
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            return students;
        }
    }
}
