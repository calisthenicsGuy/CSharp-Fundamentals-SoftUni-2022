using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.Store_Boxes
{
    class Box
    {
        public Box(int serialNumber, string item, int quantity, double priceForBox, double totalPrice)
        {
            this.SerialNumber = serialNumber;
            this.Item = item;
            this.Quantity = quantity;
            this.PriceForBox = priceForBox;
            this.TotalPrice = totalPrice;
        }
        public int SerialNumber { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public double PriceForBox { get; set; }
        public double TotalPrice { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxses = new List<Box>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int serialNumber = int.Parse(commandArgs[0]);
                string name = commandArgs[1];
                int quantity = int.Parse(commandArgs[2]);
                double price = double.Parse(commandArgs[3]);

                Box newBox = new Box(serialNumber, name, quantity, price, quantity * price);

                boxses.Add(newBox);
            }

            boxses = boxses.OrderByDescending(b => b.TotalPrice).ToList();

            foreach (Box box in boxses)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item} - ${box.PriceForBox:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.TotalPrice:f2}");
            }
        }
    }
}
