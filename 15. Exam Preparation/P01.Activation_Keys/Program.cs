using System;
using System.Linq;

namespace Task_Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] commandArgs = command
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string action = commandArgs[0];

                if (action == "Contains")
                {
                    string substring = commandArgs[1];
                    if (!activationKey.Contains(substring))
                    {
                        Console.WriteLine($"Substring not found!");
                        continue;
                    }
                    Console.WriteLine($"{activationKey} contains {substring}");
                }
                else if (action == "Flip")
                {
                    int startIndex = int.Parse(commandArgs[2]);
                    int endIndex = int.Parse(commandArgs[3]);

                    string substringToChage = "";
                    string sizeOfLetters = commandArgs[1];
                    if (sizeOfLetters == "Upper")
                    {
                        substringToChage = activationKey.Substring(startIndex, endIndex - startIndex);
                        substringToChage = substringToChage.ToUpper();
                    }
                    else if (sizeOfLetters == "Lower")
                    {
                        substringToChage = activationKey.Substring(startIndex, endIndex - startIndex);
                        substringToChage = substringToChage.ToLower();
                    }

                    activationKey = activationKey.Replace(activationKey.Substring(startIndex, endIndex - startIndex), substringToChage);

                    Console.WriteLine(activationKey);
                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    activationKey = activationKey.Remove(startIndex, endIndex-startIndex);
                    Console.WriteLine(activationKey);
                }
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
