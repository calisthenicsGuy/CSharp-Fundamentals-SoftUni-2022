using System;
using System.Linq;

namespace P01.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] randomText = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Random random = new Random();
            for (int i = 0; i < randomText.Length; i++)
            {
                int j = random.Next(randomText.Length);
                string temp = randomText[i];
                randomText[i] = randomText[j];
                randomText[j] = temp;
            }

            Console.WriteLine(string.Join("\n", randomText));
        }
    }
}
