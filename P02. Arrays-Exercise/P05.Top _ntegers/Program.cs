using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.Top__ntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            TopIntegers(array);
        }

        private static void TopIntegers(int[] array)
        {
            List<int> topIntegers = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];
                bool isTopInteger = true;

                for (int j = i + 1; j <= array.Length - 1; j++)
                {
                    int nextNum = array[j];
                    if (nextNum >= currentNum)
                    {
                        isTopInteger = false;
                    }
                }

                if (isTopInteger)
                {
                    topIntegers.Add(array[i]);
                }
            }

            Console.WriteLine(string.Join(" ", topIntegers));
        }
    }
}
