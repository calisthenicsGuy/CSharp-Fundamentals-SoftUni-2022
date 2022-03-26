using System;

namespace P02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintTheStatusOfStudent(double.Parse(Console.ReadLine()));
        }

        public static void PrintTheStatusOfStudent(double grades)
        {
            if (grades >= 2.00 && grades <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grades >= 3.00 && grades <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grades >= 3.50 && grades <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grades >= 4.50 && grades <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grades >= 5.50 && grades <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
