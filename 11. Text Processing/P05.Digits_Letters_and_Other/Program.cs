using System;
using System.Linq;

namespace P05.Digits_Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char[] allDigits = text.Where(x => char.IsDigit(x)).ToArray();
            char[] allLetters = text.Where(x => char.IsLetter(x)).ToArray();
            char[] otherCharacters = text.Where(x => !char.IsLetterOrDigit(x)).ToArray();

            Console.WriteLine(allDigits);
            Console.WriteLine(allLetters);
            Console.WriteLine(otherCharacters);
        }
    }
}
