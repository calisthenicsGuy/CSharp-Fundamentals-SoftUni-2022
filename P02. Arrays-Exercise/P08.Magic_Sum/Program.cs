using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            MagicSum(array);
        }

        private static void MagicSum(int[] array)
        {
            // 1 7 6 2 19 23

            int givenSum = int.Parse(Console.ReadLine());
            var elementsWhichAreEquelToGivenSum = new List<int>();

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == givenSum)
                    {
                        Console.WriteLine($"{array[i]} {array[j]}");
                    }
                }
            }
        }
    }
}
