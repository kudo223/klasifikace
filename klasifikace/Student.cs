using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasifikace
{
    public class Student
    {
        public int Id { get; set; }
        public string Firstname{ get; set; }
        public string Lastname{ get; set; }
        public DateTime Birthday{ get; set; }
        public List<Grade> Grades{ get; set; }

        public Student()
        {
            Grades = new List<Grade>();
        }
    }
}
