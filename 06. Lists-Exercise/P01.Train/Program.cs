using System;
using System.Linq;

namespace P01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacityOfWagon = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commandArgs[0] == "Add")
                {
                    wagons.Add(int.Parse(commandArgs[1]));
                }
                else
                {
                    int numberOfPassengers = int.Parse(commandArgs[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + numberOfPassengers <= maxCapacityOfWagon)
                        {
                            wagons[i] += numberOfPassengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
