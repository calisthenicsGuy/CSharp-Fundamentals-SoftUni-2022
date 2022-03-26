using System;
using System.Linq;

namespace P01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonsOfTrain = int.Parse(Console.ReadLine());
            int[] numberOfPassengers = new int[wagonsOfTrain];
            int sumOfPassengers = 0;

            for (int i = 0; i < numberOfPassengers.Length; i++)
            {
                numberOfPassengers[i] = int.Parse(Console.ReadLine());
                sumOfPassengers += numberOfPassengers[i];
            }

            Console.WriteLine(string.Join(" ", numberOfPassengers));
            Console.WriteLine(sumOfPassengers);
        }
    }
}
