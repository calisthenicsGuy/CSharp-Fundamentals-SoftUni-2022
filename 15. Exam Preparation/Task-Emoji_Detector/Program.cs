using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task_Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([*]{2}|[:]{2})+([A-Z][a-z]{2,})\1";
            string newpattern = @"[0-9]+";

            string text = Console.ReadLine();

            double total = 1;
            double emoji = 0;

            MatchCollection matches = Regex.Matches(text, pattern);
            MatchCollection num = Regex.Matches(text, newpattern);

            List<string> totalEmoji = new List<string>();

            foreach (Match item in num)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    total *= int.Parse(item.Value[i].ToString());
                }

            }

            foreach (Match item in matches)
            {
                string emo = item.Groups[2].Value;
                for (int i = 0; i < emo.Length; i++)
                {
                    emoji += (double)emo[i];
                }
                if (emoji > total)
                {
                    totalEmoji.Add(item.Value);
                }
                emoji = 0;
            }
            Console.WriteLine($"Cool threshold: {total}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            Console.Write(string.Join("\n", totalEmoji));
        }
    }
}
