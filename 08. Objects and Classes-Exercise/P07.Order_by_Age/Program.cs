using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.Order_by_Age
{
    class Student
    {
        public Student(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] informationArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = informationArgs[0];
                string id = informationArgs[1];
                int age = int.Parse(informationArgs[2]);

                Student existingStudent = ChangeInformation(students, id);
                if (existingStudent != null)
                {
                    existingStudent.Name = name;
                    existingStudent.Age = age;
                }
                else if (existingStudent == null)
                {
                    Student newStudent = new Student(name, id, age);
                    students.Add(newStudent);
                }
            }

            students = students.OrderBy(x => x.Age).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static Student ChangeInformation(List<Student> students, string id)
        {
            foreach (var item in students)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
