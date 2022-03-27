using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> products = new Dictionary<string, double>();
            Dictionary<string, int> productsMoreInformation = new Dictionary<string, int>();

            string command;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] receivingProduct = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string productName = receivingProduct[0];
                double price = double.Parse(receivingProduct[1]);
                int quantity = int.Parse(receivingProduct[2]);

                if (!products.ContainsKey(productName))
                {
                    products[productName] = price;
                    productsMoreInformation[productName] = quantity;
                }
                else
                {
                    products.Remove(productName);
                    products[productName] = price;
                    productsMoreInformation[productName] += quantity;
                }

            }

            foreach (var item in products)
            {
                foreach (var newItem in productsMoreInformation)
                {
                    if (item.Key == newItem.Key)
                    {
                        Console.WriteLine($"{item.Key} -> {(item.Value * newItem.Value):f2}");
                    }
                }
            }
        }
    }
}
