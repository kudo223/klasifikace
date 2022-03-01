using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace klasifikace
{
    public class SqlRepository
    {
        private string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Klasifikace;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private List<Student> TempStudents()
        {
            List<Student> students = new List<Student>();
            var student1 = new Student()
            {
                Id = 1,
                Firstname = "Pepa",
                Lastname = "Zdepa",
                Birthday = DateTime.Parse("1.1.2000"),
                Grades = new List<Grade>(),
            };
            students.Add(student1);
            var student2 = new Student()
            {
                Id = 1,
                Firstname = "Franta",
                Lastname = "Skočdopole",
                Birthday = DateTime.Parse("28.2.2000"),
                Grades = new List<Grade>(),
            };
            students.Add(student2);
            return students;
        }
        public List<Student> GetStudents()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                //List<Student> students = new List<Student>();
                sqlConnection.Close();
            }

            return TempStudents();
            //return students;
        }
    }
}
