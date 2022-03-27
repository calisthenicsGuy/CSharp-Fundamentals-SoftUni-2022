using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string courseName = commandArgs[0];
                string[] courseStudents = commandArgs[1]
                    .Split(" : x", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }

                for (int i = 0; i < courseStudents.Length; i++)
                {
                    courses[courseName].Add(courseStudents[i]);
                }
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
