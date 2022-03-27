using System;
using System.Linq;

namespace Task_WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] commandArgs = command
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string operation = commandArgs[0];

                if (operation == "Add Stop")
                {
                    AddStop(commandArgs, ref stops);
                }
                else if (operation == "Remove Stop")
                {
                    RemoveStop(commandArgs, ref stops);
                }
                else if (operation == "Switch")
                {
                    Switch(commandArgs, ref stops);
                }

                Console.WriteLine(stops);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }

        public static void Switch(string[] commandArgs, ref string stops)
        {
            string oldString = commandArgs[1];
            string newString = commandArgs[2];

            if (!stops.Contains(oldString))
            {
                return;
            }

            stops = stops.Replace(oldString, newString);
        }

        public static void RemoveStop(string[] commandArgs, ref string stops)
        {
            int startIndex = int.Parse(commandArgs[1]);
            int endIndex = int.Parse(commandArgs[2]);

            if ((startIndex >= 0 || startIndex < stops.Length) 
               && (endIndex < stops.Length))
            {
                stops = stops.Remove(startIndex, ((endIndex - startIndex) + 1));
            }
        }

        public static void AddStop(string[] commandArgs, ref string stops)
        {
            int index = int.Parse(commandArgs[1]);
            string stop = commandArgs[2];

            if (index < 0 || index >= stops.Length)
            {
                return;
            }

            stops = stops.Insert(index, stop);
        }
    }
}
