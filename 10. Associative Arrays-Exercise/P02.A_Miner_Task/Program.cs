using System;
using System.Collections.Generic;

namespace P02.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();

            string command;
            while ((command = Console.ReadLine()) != "stop")
            {
                string resource = command;
                int quantity = int.Parse(Console.ReadLine());

                if (materials.ContainsKey(resource))
                {
                    materials[resource] += quantity;
                    continue;
                }

                materials[resource] = quantity;
            }

            foreach (KeyValuePair<string, int> material in materials)
            {
                Console.WriteLine($"{material.Key} -> {material.Value}");
            }

            // 3 Motes 5 stones 5 Shards 6 leathers 255 fragments 7 Shards
            // 123 silver 6 shards 8 shards 5 motes 9 fangs 75 motes 103 MOTES 8 Shards 86 Motes 7 stones 19 silver        }
        }
    }
}
