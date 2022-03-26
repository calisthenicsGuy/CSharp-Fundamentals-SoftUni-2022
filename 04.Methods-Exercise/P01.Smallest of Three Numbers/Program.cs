using System;

namespace P01.Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            SmallestNumber(a, b, c);
        }

        private static void SmallestNumber(int a, int b, int c)
        {
            if (a < b)
            {
                if (a < c)
                {
                    Console.WriteLine(a);
                }
                else if (c < a)
                {
                    Console.WriteLine(c);
                }
            }

            else if (b < a)
            {
                if (b < c)
                {
                    Console.WriteLine(b);
                }
                else if (c < b)
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
