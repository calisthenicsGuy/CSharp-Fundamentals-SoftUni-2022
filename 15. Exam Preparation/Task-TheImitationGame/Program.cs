using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string encrtptedMessage = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] commandArgs = command
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = commandArgs[0];

                if (action == "Move")
                {
                    int numberOfLetters = int.Parse(commandArgs[1]);
                    string substringToMove = encrtptedMessage.Substring(0, numberOfLetters);
                    encrtptedMessage = encrtptedMessage.Remove(0, numberOfLetters);
                    encrtptedMessage = encrtptedMessage.Insert(encrtptedMessage.Length, substringToMove);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(commandArgs[1]);
                    string value = commandArgs[2];

                    encrtptedMessage = encrtptedMessage.Insert(index, value);
                }
                else if (action == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacementString = commandArgs[2];

                    encrtptedMessage = encrtptedMessage.Replace(substring, replacementString);
                }
            }

            Console.WriteLine($"The decrypted message is: {encrtptedMessage}");
        }
    }
}
