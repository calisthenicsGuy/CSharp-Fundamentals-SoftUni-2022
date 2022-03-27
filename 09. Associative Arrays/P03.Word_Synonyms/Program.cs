using System;
using System.Collections.Generic;

namespace P03.Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                string synoym = Console.ReadLine();

                if (words.ContainsKey(word))
                {
                    words[word].Add(synoym);
                    continue;
                }

                words[word] = new List<string>();
                words[word].Add(synoym);
            }

            foreach (var item in words)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
