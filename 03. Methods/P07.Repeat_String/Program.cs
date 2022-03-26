using System;

namespace P07.Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());

            RepeatStringMethod(text, counter);
        }

        private static void RepeatStringMethod(string text, int counter)
        {
            for (int i = 1; i <= counter; i++)
            {
                Console.Write($"{text}");
            }
        }
    }
}
