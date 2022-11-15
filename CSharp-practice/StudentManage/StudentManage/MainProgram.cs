using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_practice.StudentManagement
{
    internal class MainProgram
    {
        private static StudentManagement studentManagement = new StudentManagement();
        public static void Main(string[] args)
        {
            var selectedFunction = 0;
            ShowFunctionMenu();
            do
            {

                selectedFunction = Convert.ToInt32(Console.ReadLine());
                switch (selectedFunction)
                {
                    case 1:
                        ShowStudentList();
                        break;
                    case 2:
                        FindAStudent();
                        break;
                    case 3:
                        AddAStudent();
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            }
            while (selectedFunction != 4);
        }

        private static void ShowFunctionMenu()
        {
            Console.WriteLine("Student Management Menu: ");
            Console.WriteLine("1. Show student list ");
            Console.WriteLine("2. Find a student");
            Console.WriteLine("3. Add new student");
            Console.WriteLine("4. Exit ");
        }

        private static void ShowStudentList()
        {
            var studentList = studentManagement.GetAllStudentsFromJson();
            if (studentList != null)
            {
                foreach (Student student in studentList)
                {
                    Console.WriteLine($"-> ID({student.StudentID}), Name({student.StudentName}). Department({student.Department})");
                }
            }
        }

        private static void FindAStudent()
        {
            Console.WriteLine("Search: ... ");
            var searchText = Console.ReadLine();
            Student? studentFound = studentManagement.FindStudent(searchText);
            if (studentFound != null)
            {
                Console.WriteLine("\tResult: " + studentFound);
              
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        private static bool AddAStudent()
        {
            try
            {
                Console.WriteLine("Enter ID: ");
                var id = Console.ReadLine();
                Console.WriteLine("Enter Name: ");
                var name = Console.ReadLine();
                Console.WriteLine("Enter Department: ");
                var department = Console.ReadLine();
                var newStudent = new Student(id = id, name = name, department = department);
                studentManagement.AddStudent(newStudent);
                return true;
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("Error Input " + formatException.Message);
                return false;
            }

        }
    }
}
