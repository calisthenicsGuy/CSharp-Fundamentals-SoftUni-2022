using System;
using System.Numerics;

namespace P02.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            for (int i = n; i >= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
