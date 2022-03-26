using System;

namespace P08.Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            double n1 = int.Parse(Console.ReadLine());

            Factorial(n, n1);
        }

        private static void Factorial(double n, double n1)
        {
            double firstFactorial = 1;
            double secondFactorial = 1;

            for (int i = 1; i <= n; i++)
            {
                firstFactorial = firstFactorial * i;
            }
            for (int i = 1; i <= n1; i++)
            {
                secondFactorial = secondFactorial * i;
            }

            Console.WriteLine($"{(firstFactorial / secondFactorial):f2}");
        }
    }
}
