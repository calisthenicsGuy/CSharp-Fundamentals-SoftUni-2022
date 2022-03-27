using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] characters = Console.ReadLine()
                            .ToCharArray()
                            .Where(x => x != ' ')
                            .ToArray();

            Dictionary<char, int> occurrences = new Dictionary<char, int>();

            foreach (char character in characters)
            {
                if (!occurrences.ContainsKey(character))
                {
                    occurrences[character] = 0;
                }
                occurrences[character] += 1;
            }

            foreach (KeyValuePair<char, int> character in occurrences)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
