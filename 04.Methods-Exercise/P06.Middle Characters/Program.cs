using System;

namespace P06.Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            MiddleCharacters(text);
        }

        private static void MiddleCharacters(string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.WriteLine($"{text[text.Length / 2 - 1]}{text[text.Length / 2]}");
            }

            else if (text.Length % 2 == 1)
            {
                Console.WriteLine($"{text[text.Length / 2]}");
            }
        }
    }
}
