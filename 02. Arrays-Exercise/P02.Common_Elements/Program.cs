using System;
using System.Linq;

namespace P02.Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] randomText = Console.ReadLine()
                .Split()
                .ToArray();

            string[] randomText1 = Console.ReadLine()
                .Split()
                .ToArray();

            for (int i = 0; i < randomText1.Length; i++)
            {
                for (int j = 0; j < randomText.Length; j++)
                {
                    if (randomText1[i].Contains(randomText[j]))
                    {
                        Console.Write($"{randomText1[i]} ");
                    }
                }
            }
        }
    }
}
