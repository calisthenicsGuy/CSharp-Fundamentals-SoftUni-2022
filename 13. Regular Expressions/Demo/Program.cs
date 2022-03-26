using System;
using System.Text.RegularExpressions;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string emailInput1 = "radev12@gmail.com";
            string emailInput2 = @"invalid*name@emai1.bg";
            string emailInput3 = @"____ examples: radev12@gmail.com  ----  invalid*name@emai1.bg -----  goshoOtPochivka66@abv.bg";

            string emailPattern = @"([A-Za-z0-9]+)\@([a-z]+)\.(\w{2,})";
            Regex regex = new Regex(emailPattern);

            //bool isMatch = regex.IsMatch(emailInput2);
            //Console.WriteLine(isMatch);

            Match match = regex.Match(emailInput3);
            Console.WriteLine(match.Success);
            Console.WriteLine(match.Value);
            Console.WriteLine(match.Index);
            Console.WriteLine(match.Length);
            Console.WriteLine(match.NextMatch());
            //Console.WriteLine(matches.Equals(@"examples"));
            //Console.WriteLine(matches);

            Console.WriteLine();
            
            Console.WriteLine(match.Groups[1].Value);
            Console.WriteLine(match.Groups[2].Value);

            MatchCollection matches = regex.Matches(emailInput3);
            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
