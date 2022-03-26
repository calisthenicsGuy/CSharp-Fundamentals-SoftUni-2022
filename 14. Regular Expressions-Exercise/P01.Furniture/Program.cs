using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P01.Furniture
{
    class Furniture
    {
        public Furniture(string name, double price, int quant)
        {
            this.Name = name;
            this.Price = price;
            this.Quant = quant;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quant { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> furnitures = new List<Furniture>();
            string orderPattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(.\d+)?)!(?<quant>\d+)";

            string command;
            while ((command = Console.ReadLine()) != "Purchase")
            {
                Regex regex = new Regex(orderPattern);

                if (!regex.IsMatch(command))
                {
                    continue;
                }
                Match match = Regex.Match(command, orderPattern);

                Furniture newFurniture = new Furniture(match.Groups["name"].Value, double.Parse(match.Groups["price"].Value), int.Parse(match.Groups["quant"].Value));

                furnitures.Add(newFurniture);
            }

            double totalPrice = 0.0;
            Console.WriteLine($"Bought furniture:");
            foreach (Furniture furniture in furnitures)
            {
                totalPrice += furniture.Price * furniture.Quant;
                Console.WriteLine($"{furniture.Name}");
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
