using System;

namespace P06.Calculate_Rectangle_Area
{
    class Program
    {
        public static int PrintArea(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PrintArea(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
    }
}
