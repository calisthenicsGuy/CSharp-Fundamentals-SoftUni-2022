using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.VehicleCatalogue
{
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }

        public Truck(string brand, string model, double weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }

        public Car(string brand, string model, double horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
    }

    class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalogObject = new Catalog();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split("/", StringSplitOptions.RemoveEmptyEntries);
                string typeOfVehicle = commandArgs[0];
                string brand = commandArgs[1];
                string model = commandArgs[2];

                if (typeOfVehicle == "Car")
                {
                    double horsePower = double.Parse(commandArgs[3]);

                    Car newCar = new Car(brand, model, horsePower);
                    catalogObject.Cars.Add(newCar);
                }

                else if (typeOfVehicle == "Truck")
                {
                    double weight = double.Parse(commandArgs[3]);

                    Truck newTruck = new Truck(brand, model, weight);
                    catalogObject.Trucks.Add(newTruck);
                }
            }

            List<Car> orderedCars = catalogObject.Cars.OrderBy(b => b.Brand).ToList();
            List<Truck> orderedTruck = catalogObject.Trucks.OrderBy(b => b.Brand).ToList();

            if (orderedCars.Count != 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (orderedTruck.Count != 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in orderedTruck)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
