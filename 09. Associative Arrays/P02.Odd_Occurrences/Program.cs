using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine().ToLower();
            string[] wordsArgs = words
                .Split(" ", StringSplitOptions.None)
                .ToArray();

            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            foreach (var item in wordsArgs)
            {
                if (occurrences.ContainsKey(item))
                {
                    occurrences[item]++;
                }
                else
                {
                    occurrences[item] = 1;
                }
            }

            foreach (var item in occurrences)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
