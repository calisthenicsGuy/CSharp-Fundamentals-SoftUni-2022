using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string companyName = commandArgs[0];
                string id = commandArgs[1];


                if (!companyUsers.ContainsKey(companyName))
                {
                    companyUsers[companyName] = new List<string>();
                }
                else
                {
                    if (companyUsers[companyName].Contains(id))
                    {
                        continue;
                    }
                }

                companyUsers[companyName].Add(id);
            }

            foreach (KeyValuePair<string, List<string>> companyUser in companyUsers)
            {
                Console.WriteLine($"{companyUser.Key}");
                foreach (var id in companyUser.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
