using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Task_Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] commandArgs = command
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string operation = commandArgs[0];

                if (operation == "InsertSpace")
                {
                    InsertSpace(commandArgs, ref message);
                }
                else if (operation == "Reverse")
                {
                    bool isContains = true;
                    Reverse(commandArgs, ref message, ref isContains);

                    if (!isContains)
                    {
                        continue;
                    }
                }
                else if (operation == "ChangeAll")
                {
                    ChangeAll(commandArgs, ref message);
                }

                Console.WriteLine(message);
            }

            Console.WriteLine($"You have a new text message: {message}");
        }

        public static void ChangeAll(string[] commandArgs, ref string message)
        {
            string substring = commandArgs[1];
            string replacement = commandArgs[2];

            message = message.Replace(substring, replacement);
        }

        public static void Reverse(string[] commandArgs, ref string message, ref bool isContains)
        {
            string substring = commandArgs[1];

            if (!message.Contains(substring.ToString()))
            {
                isContains = false;
                Console.WriteLine("error");
                return;
            }

            message = message.Remove(message.IndexOf(substring.ToString()), substring.Length);
            StringBuilder reverseSubstring = new StringBuilder();
            for (int i = substring.Length - 1; i >= 0; i--)
            {
                reverseSubstring.Append(substring[i]);
            }

            message = message.Insert(message.Length, reverseSubstring.ToString());
        }

        public static void InsertSpace(string[] commandArgs, ref string message)
        {
            int index = int.Parse(commandArgs[1]);

            message = message.Insert(index, " ");
        }
    }
}
