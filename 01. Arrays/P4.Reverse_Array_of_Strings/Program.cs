using System;
using System.Linq;

namespace P4.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Array.Reverse(text);

            Console.WriteLine(string.Join(" ", text));
        }
    }
}
