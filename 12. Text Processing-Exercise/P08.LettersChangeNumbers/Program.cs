using System;
using System.Linq;

namespace P08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            decimal sum = 0;

            foreach (string word in input)
            {
                sum += GetResultOfASingleWord(word);
            }

            Console.WriteLine($"{sum:f2}");
        }

        public static decimal GetResultOfASingleWord(string word)
        {
            decimal singleSum = 0;
            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            int number = int.Parse(word.Substring(1, word.Length - 2));


            if (char.IsUpper(firstLetter))
            {
                singleSum = (decimal)number / GetAlphabetPositionOfCharacter(firstLetter);
            }
            else if (char.IsLower(firstLetter))
            {
                singleSum = (decimal)number * GetAlphabetPositionOfCharacter(firstLetter);
            }

            if (char.IsUpper(lastLetter))
            {
                singleSum -= GetAlphabetPositionOfCharacter(lastLetter);
            }
            else if (char.IsLower(lastLetter))
            {
                singleSum += GetAlphabetPositionOfCharacter(lastLetter);
            }

            return singleSum;
        }

        public static int GetAlphabetPositionOfCharacter(char ch)
        {
            if (!char.IsLetter(ch))
            {
                return -1;
            }

            return (int)char.ToLowerInvariant(ch) - 96;
        }
    }
}
