using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.Students_2._0
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        public Student(string firsttName, string lastName, int age, string homeTown)
        {
            this.FirstName = firsttName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] currentStudentInformation = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string firstName = currentStudentInformation[0];
                string lastName = currentStudentInformation[1];
                int age = int.Parse(currentStudentInformation[2]);
                string homeTown = currentStudentInformation[3];

                if (DoesStudentExsist(students, firstName, lastName))
                {
                    Student getExsistingStudent = students.FirstOrDefault(s =>
                                                           s.FirstName == firstName && s.LastName == lastName);

                    getExsistingStudent.Age = age;
                    getExsistingStudent.HomeTown = homeTown;
                }
                else
                {
                    Student newStudent = new Student(firstName, lastName, age, homeTown);
                    students.Add(newStudent);
                }
            }

            string searchTown = Console.ReadLine();

            List<Student> studentsFromSearchTown = students
                                                   .FindAll(s => s.HomeTown == searchTown);

            foreach (Student student in studentsFromSearchTown)
            {
                Console.WriteLine(student);
            }
        }

        private static bool DoesStudentExsist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
