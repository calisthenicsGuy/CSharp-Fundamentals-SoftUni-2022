using System;
using System.Text.RegularExpressions;

namespace P01.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePattern = @"\b([A-Z][a-z]{1,}) ([A-Z][a-z]{1,})\b";
            // @"\b(?<name>[A-Z]{1}[a-z]{3,})\s\g<name>\b"
            string names = Console.ReadLine();

            Regex regex = new Regex(namePattern);
            MatchCollection nameMatches = regex.Matches(names);
            //MatchCollection matches = Regex.Matches(names, namePattern);


            foreach (Match name in nameMatches)
            {
                Console.Write($"{name.Value} ");
            }
            //Console.WriteLine(string.Join(" ", matches));
        }
    }
}
