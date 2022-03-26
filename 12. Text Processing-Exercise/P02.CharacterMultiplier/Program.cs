using System;
using System.Linq;

namespace P02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            string firstText = input[0];
            string secondText = input[1];

            GetSum(firstText, secondText);
        }

        private static void GetSum(string firstText, string secondText)
        {
            int sum = 0;

            int minLength = Math.Min(firstText.Length, secondText.Length);

            for (int i = 0; i < minLength; i++)
            {
                sum += (int)firstText[i] * (int)secondText[i];
            }

            string largestLength = secondText;
            if (firstText.Length >= secondText.Length)
            {
                largestLength = firstText;
            }

            for (int i = minLength; i < largestLength.Length; i++)
            {
                sum += (int)largestLength[i];
            }

            Console.WriteLine(sum);
        }
    }
}
