using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                double grades = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                }
                students[name].Add(grades);
            }

            foreach (KeyValuePair<string, List<double>> student in students)
            {
                if (student.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {(student.Value.Average()):f2}");
                }
            }
        }
    }
}
