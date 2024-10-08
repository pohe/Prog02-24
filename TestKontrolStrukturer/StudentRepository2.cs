using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKontrolStrukturer
{
    public class StudentRepository2
    {
        private Dictionary<string, Student> _students;


        public StudentRepository2()
        {
            _students = new Dictionary<string, Student>();
        }

        public void AddStudent(Student s)
        {
            if (!_students.ContainsKey(s.SSN))
            {
                _students.Add(s.SSN, s);
            }
        }

        public void RemoveStudent(string ssn) 
        {
            _students.Remove(ssn);
        }

    }
}
