using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Task_Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> carsMileage = new Dictionary<string, int>();
            Dictionary<string, int> carsFuel = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] carInformation = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string car = carInformation[0];
                int mileage = int.Parse(carInformation[1]);
                int fuel = int.Parse(carInformation[2]);

                carsMileage[car] = mileage;
                carsFuel[car] = fuel;
            }

            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commandArgs = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = commandArgs[0];
                string car = commandArgs[1];

                if (action == "Drive")
                {
                    Drive(carsMileage, carsFuel, car, commandArgs);
                }
                else if (action == "Refuel")
                {
                    Refuel(carsMileage, carsFuel, car, commandArgs);
                }
                else if (action == "Revert")
                {
                    Revert(carsMileage, carsFuel, car, commandArgs);

                }
            }

            PrintingOutput(carsMileage, carsFuel);
        }

        public static void PrintingOutput(Dictionary<string, int> carsMileage, Dictionary<string, int> carsFuel)
        {
            foreach (KeyValuePair<string, int> car in carsMileage.OrderByDescending(m => m.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value} kms, Fuel in the tank: {carsFuel[car.Key]} lt.");
            }
        }

        public static void Revert(Dictionary<string, int> carsMileage, Dictionary<string, int> carsFuel, string car, string[] commandArgs)
        {
            int kilometers = int.Parse(commandArgs[2]);

            carsMileage[car] -= kilometers;

            if (carsMileage[car] < 10000)
            {
                carsMileage[car] = 10000;
                return;
            }

            Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
        }

        public static void Refuel(Dictionary<string, int> carsMileage, Dictionary<string, int> carsFuel, string car, string[] commandArgs)
        {
            int fuel = int.Parse(commandArgs[2]);

            if ((carsFuel[car] + fuel) >= 75)
            {
                Console.WriteLine($"{car} refueled with {75 - carsFuel[car]} liters");
                carsFuel[car] = 75;
                return;
            }

            carsFuel[car] += fuel;
            Console.WriteLine($"{car} refueled with {fuel} liters");
        }

        public static void Drive(Dictionary<string, int> carsMileage, Dictionary<string, int> carsFuel, string car, string[] commandArgs)
        {
            int distance = int.Parse(commandArgs[2]);
            int fuel = int.Parse(commandArgs[3]);

            if (fuel > carsFuel[car])
            {
                Console.WriteLine("Not enough fuel to make that ride");
                return;
            }


            carsMileage[car] += distance;
            carsFuel[car] -= fuel;

            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

            if (carsMileage[car] > 100000)
            {
                carsMileage.Remove(car);
                Console.WriteLine($"Time to sell the {car}!");
            }
        }
    }
}
