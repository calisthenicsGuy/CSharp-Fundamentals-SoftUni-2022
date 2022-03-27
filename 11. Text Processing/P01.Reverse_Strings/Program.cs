using System;

namespace P01.Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string reverseCommand = null;
                for (int i = command.Length - 1; i >= 0; i--)
                {
                    reverseCommand += command[i];
                }
                Console.WriteLine($"{command} = {reverseCommand}");
            }
        }
    }
}
