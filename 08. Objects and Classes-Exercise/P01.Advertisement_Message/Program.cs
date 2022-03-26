using System;

namespace P01.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[]
                {
                    "Excellent product.", "Such a great product.", "I always use that product.",
                    "Best product of its category", "Exceptional product.", "I can’t live without this product."
            };

            string[] events = new string[]
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };
            string[] authors = new string[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            string[] cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            var rndPhrases = new Random();
            var rndEvents = new Random();
            var rndAuthors = new Random();
            var rndCities = new Random();


            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int rndPhrasesIndex = rndPhrases.Next(0, phrases.Length);
                int rndEventsIndex = rndEvents.Next(0, events.Length);
                int rndAuthorsIndex = rndAuthors.Next(0, authors.Length);
                int rndCititesIndex = rndCities.Next(0, cities.Length);

                Console.WriteLine($"{phrases[rndPhrasesIndex]} {events[rndEventsIndex]} {authors[rndAuthorsIndex]} - {cities[rndCititesIndex]}");
            }
        }
    }
}
