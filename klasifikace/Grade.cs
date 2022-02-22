using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasifikace
{
    public class Grade
    {
        public int Id { get; set; }
        public int GradeNumber { get; set; }
        public Subject Subject { get; set; }
        public double Weight { get; set; }
        public string Comment { get; set; }
    }
}
