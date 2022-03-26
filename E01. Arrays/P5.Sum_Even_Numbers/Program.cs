using System;
using System.Linq;

namespace P5.Sum_Even_Numbers
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
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumOfEvenNumbers += array[i];
                }
            }

            Console.WriteLine(sumOfEvenNumbers);
        }
    }
}
