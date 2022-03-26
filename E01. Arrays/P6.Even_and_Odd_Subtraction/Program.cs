using System;
using System.Linq;

namespace P6.Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sumOfEvenNumbers = 0;
            int sumOfOddNumbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumOfEvenNumbers += array[i];
                }
                else if (array[i] % 2 != 0)
                {
                    sumOfOddNumbers += array[i];
                }
            }

            Console.WriteLine(sumOfEvenNumbers - sumOfOddNumbers);
        }
    }
}
