using System;
using System.Text.RegularExpressions;

namespace P02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumberPattern = @"\+359( |-)[2]\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();

            MatchCollection matchedPhoneNumbers = Regex.Matches(input, phoneNumberPattern);

            Console.WriteLine(string.Join(", ", matchedPhoneNumbers));
        }
    }
}
