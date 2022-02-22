using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasifikace
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public Teacher Teacher { get; set; }
    }
}
