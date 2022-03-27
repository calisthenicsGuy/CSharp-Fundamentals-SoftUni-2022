using System;

namespace P03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string substringToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            int indexOfSubstringInText = text.IndexOf(substringToRemove);

            while (indexOfSubstringInText != -1)
            {
                text = text.Remove(indexOfSubstringInText, substringToRemove.Length);
                indexOfSubstringInText = text.IndexOf(substringToRemove);
            }

            Console.WriteLine(text);
        }
    }
}
