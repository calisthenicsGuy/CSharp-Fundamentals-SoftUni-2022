using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {(this.Grade):f2}";
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int numberOfStudent = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfStudent; i++)
            {
                string[] studentInformation = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string firstName = studentInformation[0];
                string lastName = studentInformation[1];
                double grade = double.Parse(studentInformation[2]);

                Student newStudent = new Student(firstName, lastName, grade);
                students.Add(newStudent);
            }

            students = students.OrderByDescending(g => g.Grade).ToList();


            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
