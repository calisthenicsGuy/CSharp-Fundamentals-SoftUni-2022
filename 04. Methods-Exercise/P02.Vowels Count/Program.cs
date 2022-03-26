using System;
using System.Collections.Generic;

namespace P02.Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            VowelsCount(text);
        }

        private static void VowelsCount(string text)
        {
            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char temp = (text[i]);

                if (vowels.Contains(temp))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
