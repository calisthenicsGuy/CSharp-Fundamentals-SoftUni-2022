using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> occurrences = new SortedDictionary<double, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (occurrences.ContainsKey(numbers[i]))
                {
                    occurrences[numbers[i]]++;
                }
                else
                {
                    occurrences[numbers[i]] = 1;
                }
            }

            foreach (var number in occurrences)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
