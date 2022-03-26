using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.VehicleCatalogue
{
    class Car
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public Car(string type, string model, string color, int horsePower)
        {
            type = "Car";
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
    }

    class Truck
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public Truck(string type, string model, string color, int horsePower)
        {
            type = "Truck";
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
    }
    class VehicleCatalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

        public VehicleCatalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            VehicleCatalog catalogObject = new VehicleCatalog();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = commandArgs[0];
                string model = commandArgs[1];
                string color = commandArgs[2];
                int horsePower = int.Parse(commandArgs[3]);


                if (type == "car")
                {
                    Car newCar = new Car(type, model, color, horsePower);
                    catalogObject.Cars.Add(newCar);
                }

                else if (type == "truck")
                {
                    Truck newTruck = new Truck(type, model, color, horsePower);
                    catalogObject.Trucks.Add(newTruck);
                }
            }


            double averageCarHosePower = 0.0;
            double averageTruckHosePower = 0.0;

            string seachedVehicles;
            while ((seachedVehicles = Console.ReadLine()) != "Close the Catalogue")
            {
                Car temp1 = catalogObject.Cars.FirstOrDefault(m => m.Model == seachedVehicles);
                Truck temp2 = catalogObject.Trucks.FirstOrDefault(m => m.Model == seachedVehicles);

                if (temp1 != null)
                {
                    Console.WriteLine($"Type: {temp1.Type}");
                    Console.WriteLine($"Model: {temp1.Model}");
                    Console.WriteLine($"Color: {temp1.Color}");
                    Console.WriteLine($"Horsepower: {temp1.HorsePower}");
                }
                else if (temp2 != null)
                {
                    Console.WriteLine($"Type: {temp2.Type}");
                    Console.WriteLine($"Model: {temp2.Model}");
                    Console.WriteLine($"Color: {temp2.Color}");
                    Console.WriteLine($"Horsepower: {temp2.HorsePower}");
                }
            }


            if (catalogObject.Cars.Count != 0)
            {
                foreach (Car car in catalogObject.Cars)
                {
                    averageCarHosePower += car.HorsePower;
                }
                averageCarHosePower = averageCarHosePower / catalogObject.Cars.Count;

                Console.WriteLine($"Cars have average horsepower of: {averageCarHosePower:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }


            if (catalogObject.Trucks.Count != 0)
            {
                foreach (Truck truck in catalogObject.Trucks)
                {
                    averageTruckHosePower += truck.HorsePower;
                }
                averageTruckHosePower = averageTruckHosePower / catalogObject.Trucks.Count;

                Console.WriteLine($"Trucks have average horsepower of: {averageTruckHosePower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
}
