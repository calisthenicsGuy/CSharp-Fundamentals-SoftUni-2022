using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<int> reversedString = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                int[] temp = array[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < temp.Length; j++)
                {
                    reversedString.Insert(j, temp[j]);
                }
            }

            Console.WriteLine(string.Join(" ", reversedString));
        }
    }
}
