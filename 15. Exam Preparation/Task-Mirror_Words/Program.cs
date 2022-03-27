using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Task_Mirror_Words
{
    class MirrorWord
    {
        public MirrorWord(string firstWord, string secondWord)
        {
            this.FirstWord = firstWord;
            this.SecondWord = secondWord;
        }

        public string FirstWord { get; set; }
        public string SecondWord { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<MirrorWord> mirrorWords = new List<MirrorWord>();

            string patternWord = @"([@|#])(?<word1>[A-Za-z]{3,})\1\1(?<word2>[A-Za-z]{3,})\1";

            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, patternWord);

            if (matches.Count == 0)
            {
                Console.WriteLine($"No word pairs found!");

            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            foreach (Match match in matches)
            {
                string firstWord = match.Groups["word1"].Value;
                string secondWord = match.Groups["word2"].Value;

                if (firstWord == string.Join("", secondWord.Reverse()))
                {
                    MirrorWord newWord = new MirrorWord(firstWord, secondWord);
                    mirrorWords.Add(newWord);
                }
            }

            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
                return;
            }

            string[] message = mirrorWords
                .Select(word => $"{word.FirstWord} <=> {word.SecondWord}")
                .ToArray();

            Console.WriteLine("The mirror words are:");
            Console.WriteLine(string.Join(", ", message));
        }
    }
}
