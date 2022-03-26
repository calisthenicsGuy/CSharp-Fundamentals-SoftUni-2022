using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] != input[i+1])
                {
                    Console.Write(input[i]);
                }
            }

            Console.WriteLine(input[input.Length - 1]);
        }
    }
}
