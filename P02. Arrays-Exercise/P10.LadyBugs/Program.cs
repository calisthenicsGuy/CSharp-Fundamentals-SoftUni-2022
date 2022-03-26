using System;
using System.Linq;

namespace P10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfTheField = int.Parse(Console.ReadLine());

            int[] initialIndexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[sizeOfTheField];
            for (int i = 0; i < field.Length; i++)
            {
                if (initialIndexes.Contains(i))
                {
                    field[i] = 1;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int ladybugIndex = int.Parse(commandArgs[0]);
                string direction = commandArgs[1];
                int flyLength = int.Parse(commandArgs[2]);

                if (ladybugIndex < 0 || ladybugIndex >= field.Length)
                {
                    continue;
                }
                if (field[ladybugIndex] == 0)
                {
                    continue;
                }

                // 1 0 0 1 0 1 1
                // 0 right 3
                int nextIndex = ladybugIndex;
                field[ladybugIndex] = 0;
                while (true)
                {
                    if (direction == "right")
                    {
                        nextIndex += flyLength;
                    }

                    else if (direction == "left")
                    {
                        nextIndex -= flyLength;
                    }

                    if (nextIndex < 0 || nextIndex >= field.Length)
                    {
                        break;
                    }
                    if (field[nextIndex] == 0)
                    {
                        break;
                    }
                }

                if (nextIndex >= 0 && nextIndex < field.Length)
                {
                    field[nextIndex] = 1;
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
