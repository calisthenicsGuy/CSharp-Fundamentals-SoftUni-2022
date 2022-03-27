using System;
using System.Text.RegularExpressions;

namespace Task_Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([\#|\|])(?<food>[A-Za-z\s]+)\1(?<data>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<calories>\d+)(\1)";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            int calories = 0;
            foreach (Match match in matches)
            {
                calories += int.Parse(match.Groups["calories"].Value);
            }

            int days = calories / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["food"].Value}, Best before: {match.Groups["data"].Value}, Nutrition: {match.Groups["calories"].Value}");
            }
        }
    }
}
