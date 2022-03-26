using System;

namespace P1.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[7]
                            { "Monday", "Tuesday" ,"Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            int command = int.Parse(Console.ReadLine());

            if (command < 1 || command > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[command - 1]);
            }
        }
    }
}
