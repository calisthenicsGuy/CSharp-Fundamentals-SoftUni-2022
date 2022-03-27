using System;
using System.Linq;

namespace P02.Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

            foreach (string text in input)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write(text);
                }
            }
        }
    }
}
