using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            string[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length % 2 == 0)
                .ToArray();

            foreach (var item in array)
            {
                words[item] = item.Length;
            }

            foreach (var item in words)
            {
                Console.WriteLine($"{item.Key}");
            }
        }
    }
}
