using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKontrolStrukturer
{
    public class StudentRepository
    {
        private List<Student> _students;

        public StudentRepository()
        {
            _students = new List<Student>();
        }

        public void Add(Student student)
        {
            _students.Add(student);
        }

    }
}
