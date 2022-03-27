using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace Task_P_rates
{
    class City
    {
        public City(int population, int gold)
        {
            this.Population = population;
            this.Gold = gold;
        }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> cities = new Dictionary<string, City>();

            string command;
            while ((command = Console.ReadLine()) != "Sail")
            {
                string[] commandArgs = command
                    .Split("||", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string city = commandArgs[0];
                int population = int.Parse(commandArgs[1]);
                int gold = int.Parse(commandArgs[2]);

                if (cities.ContainsKey(city))
                {
                    cities[city].Population += population;
                    cities[city].Gold += gold;
                }
                else
                {
                    cities[city] = new City(population, gold);
                }
            }

            command = null;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];
                string town = commandArgs[1];

                if (action == "Plunder")
                {
                    int population = int.Parse(commandArgs[2]);
                    int gold = int.Parse(commandArgs[3]);

                    cities[town].Population -= population;
                    cities[town].Gold -= gold;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {population} citizens killed.");

                    if (cities[town].Population == 0 || cities[town].Gold == 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        cities.Remove(town);
                        continue;
                    }
                }
                else if (action == "Prosper")
                {
                    int gold = int.Parse(commandArgs[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        continue;
                    }

                    cities[town].Gold += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town].Gold} gold.");
                }
            }

            Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
            foreach (KeyValuePair<string, City> city in cities)
            {
                Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
            }
        }
    }
}
