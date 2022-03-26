using System;
using System.Linq;

namespace P02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int element = int.Parse(commandArgs[1]);

                if (commandArgs[0] == "Delete")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == element)
                        {
                            list.RemoveAt(i);
                        }
                    }
                }
                else if (commandArgs[0] == "Insert")
                {
                    list.Insert(int.Parse(commandArgs[2]), element);
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
