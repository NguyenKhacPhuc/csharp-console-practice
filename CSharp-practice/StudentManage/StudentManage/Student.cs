using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_practice.StudentManagement
{
    internal class Student
    {
        private string _studentId;
        private string _studentName;
        private string _department;
        public string StudentID { get => _studentId; set => _studentId = value; }
        public string StudentName { get => _studentName; set => _studentName = value; }
        public string Department { get => _department; set => _department = value; }
        public Student()
        {
            _studentId = "0";
            _studentName = "Unknown";
            _department = "Unknown";
        }
        public Student(string studentId)
        {
            _studentId = studentId;
        }
        public Student(string studentId, string studentName) : this(studentId)
        {
            _studentName = studentName;
        }
        public Student(string studentId, string studentName, string department) : this(studentId, studentName)
        {
            _department = department;
        }
    }
}