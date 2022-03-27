using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registers = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = input[1];

                if (input[0] == "register")
                {
                    string plateNumber = input[2];

                    bool isRegistered = false;
                    foreach (KeyValuePair<string, string> item in registers)
                    {
                        if (item.Key == name)
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {item.Value}");
                            isRegistered = true;
                            continue;
                        }
                    }
                    if (!isRegistered)
                    {
                        registers[name] = plateNumber;
                        Console.WriteLine($"{name} registered {plateNumber} successfully");
                    }
                }

                else if (input[0] == "unregister")
                {
                    if (!registers.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                        continue;
                    }
                    registers.Remove(name);
                    Console.WriteLine($"{name} unregistered successfully");
                }
            }

            foreach (KeyValuePair<string, string> register in registers)
            {
                Console.WriteLine($"{register.Key} => {register.Value}");
            }
        }
    }
}
