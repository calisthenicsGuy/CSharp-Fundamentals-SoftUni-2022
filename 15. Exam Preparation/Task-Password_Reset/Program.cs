using System;
using System.Linq;

namespace Task_Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] commandArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = commandArgs[0];

                if (action == "TakeOdd")
                {
                    char[] oddChars = password
                        .Where((symbol, index) => index % 2 != 0)
                        .ToArray();

                    password = string.Join("", oddChars);
                }
                else if (action == "Cut")
                {
                    int index = int.Parse(commandArgs[1]);
                    int length = int.Parse(commandArgs[2]);

                    password = password.Remove(index, length);
                }
                else if (action == "Substitute")
                {
                    string substring = commandArgs[1];
                    string substitute = commandArgs[2];

                    if (!password.Contains(substring))
                    {
                        Console.WriteLine("Nothing to replace!");
                        continue;
                    }

                    password = password.Replace(substring, substitute);
                }

                Console.WriteLine(password);
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
