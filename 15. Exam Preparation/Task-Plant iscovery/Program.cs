using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_Plant_Discovery
{
    /*class Plant
    {
        public Plant(int rarity)
        {
            this.Rarity = rarity;
            this.Rating = new List<double>();
        }

        public int Rarity { get; set; }
        public List<double> Rating { get; set; }
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            #region: First Solution
            /*Dictionary<string, Plant> plants = new Dictionary<string, Plant>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] plantInformation = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = plantInformation[0];
                int rarity = int.Parse(plantInformation[1]);

                if (!plants.ContainsKey(name))
                {
                    plants[name] = new Plant(rarity);
                }
                else
                {
                    plants[name].Rarity += rarity; 
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] commandArgs = command
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string action = commandArgs[0];

                string[] plantInformation = commandArgs[1]
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string plantName = plantInformation[0];

                if (action == "Rate")
                {
                    double rating = double.Parse(plantInformation[1]);
                    plants[plantName].Rating.Add(rating);
                }
                else if (action == "Update")
                {
                    int newRarity = int.Parse(plantInformation[1]);
                    plants[plantName].Rarity = newRarity;
                }
                else if (action == "Reset")
                {
                    for (int i = 0; i < plants[plantName].Rating.Count; i++)
                    {
                        plants[plantName].Rating[i] = 0;
                    }

                    plants[plantName].Rating.RemoveAll(x => x == 0);
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (KeyValuePair<string, Plant> plant in plants)
            {
                if (plant.Value.Rating.Count > 0)
                {
                    Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {plant.Value.Rating.Average():f2}");
                }
                else
                {
                    Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: 0.00");
                }
            }*/
            #endregion

            Dictionary<string, int> plantRarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantRatings =
                new Dictionary<string, List<double>>();

            ReadPlantsRarity(plantRarity);

            string cmd;
            while ((cmd = Console.ReadLine()) != "Exhibition")
            {
                string[] cmdInfo = cmd
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = cmdInfo[0];
                string[] cmdArgs = cmdInfo[1]
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string plantName = cmdArgs[0];
                if (cmdType == "Rate")
                {
                    double plantRating = double.Parse(cmdArgs[1]);

                    AddPlantRating(plantRarity, plantRatings, plantName, plantRating);
                }
                else if (cmdType == "Update")
                {
                    int newRarity = int.Parse(cmdArgs[1]);

                    UpdateRarity(plantRarity, plantName, newRarity);
                }
                else if (cmdType == "Reset")
                {
                    ResetEntry(plantRarity, plantRatings, plantName);
                }
            }

            PrintOutputInformation(plantRarity, plantRatings);
        }

        static void PrintOutputInformation(Dictionary<string, int> plantRarity,
            Dictionary<string, List<double>> plantRatings)
        {
            Console.WriteLine($"Plants for the exhibition:");
            foreach (KeyValuePair<string, int> kvp in plantRarity)
            {
                string plantName = kvp.Key;
                int rarity = kvp.Value;
                double avgRating = 0;

                if (plantRatings.ContainsKey(plantName) && plantRatings[plantName].Any())
                {
                    avgRating = plantRatings[plantName].Average();
                }

                Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: {avgRating:f2}");
            }
        }

        static void ResetEntry(Dictionary<string, int> plantRarity,
            Dictionary<string, List<double>> plantRatings, string plantName)
        {
            if (!plantRarity.ContainsKey(plantName))
            {
                Console.WriteLine("error");
                return;
            }

            if (plantRatings.ContainsKey(plantName))
            {
                plantRatings[plantName].Clear();
            }
        }

        static void UpdateRarity(Dictionary<string, int> plantRarity, string plantName, int newRarity)
        {
            if (plantRarity.ContainsKey(plantName))
            {
                plantRarity[plantName] = newRarity;
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        static void AddPlantRating(Dictionary<string, int> plantRarity,
            Dictionary<string, List<double>> plantRatings, string plantName, double rating)
        {
            if (!plantRarity.ContainsKey(plantName))
            {
                Console.WriteLine("error");
                return;
            }

            if (!plantRatings.ContainsKey(plantName))
            {
                plantRatings[plantName] = new List<double>();
            }

            plantRatings[plantName].Add(rating);
        }

        static void ReadPlantsRarity(Dictionary<string, int> plantRarity)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] plantInfo = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string plantName = plantInfo[0];
                int rarity = int.Parse(plantInfo[1]);

                plantRarity[plantName] = rarity;
            }
        }
    }
}
