using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_practice.StudentManagement
{
    internal class StudentManagement
    {
        public bool AddStudent(Student voter)
        {
            var studentList = GetAllStudentsFromJson();
            if (studentList != null)
            {
                studentList.Add(voter);
                string json = JsonConvert.SerializeObject(studentList);
                using (StreamWriter outputFile = new StreamWriter(@"C:\Users\phucb\source\repos\csharp-console-practice\CSharp-practice\StudentManage\StudentManage\students_data.json"))
                {
                    outputFile.Close();
                }
                return true;
            }
            return false;  
        }

        public Student? FindStudent(String searchText)
        {
            var studentList = GetAllStudentsFromJson();
            if (studentList != null && studentList.Count > 0)
            {
                return studentList.Find(student => student.StudentName.Contains(searchText) || student.StudentID.ToString().Contains(searchText) || student.Department.Contains(searchText));
            }
            else
            {
                return null;
            }

        }

        public List<Student>? GetAllStudentsFromJson()
        {
            using (StreamReader streamReader = File.OpenText(@"C:\Users\phucb\source\repos\csharp-console-practice\CSharp-practice\StudentManage\StudentManage\students_data.json"))
            {
                var obj = streamReader.ReadToEnd();
                List<Student>? studentList = JsonConvert.DeserializeObject<List<Student>>(obj);
                streamReader.Close();
                return studentList;
            }
        }
    }
}
