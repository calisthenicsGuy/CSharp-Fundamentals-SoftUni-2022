using System;

namespace P08.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            MathPower(number, power);
        }

        private static void MathPower(double number, int power)
        {
            double result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            Console.WriteLine(result);
        }
    }
}
