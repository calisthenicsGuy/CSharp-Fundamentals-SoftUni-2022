using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P05.Nether_Realms
{
    class Demon
    {
        public Demon(string name, int health, double demage)
        {
            this.Name = name;
            this.Health = health;
            this.Demage = demage;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public double Demage { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] demonsName = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<Demon> demons = new List<Demon>();

            foreach (string demon in demonsName)
            {
                int health = GetHealth(demon);
                double demage = GetDemage(demon);

                Demon newDemon = new Demon(demon, health, demage);
                demons.Add(newDemon);
            }

            PrintingDemons(demons);
        }

        public static void PrintingDemons(List<Demon> demons)
        {
            foreach (Demon demon in demons.OrderByDescending(h => h.Health))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Demage:f2} damage");
            }
        }

        public static double GetDemage(string demon)
        {
            string pattern = @"(-)?(\d+(.\d+)?)";
            double demage = 0.0;

            MatchCollection matches = Regex.Matches(demon, pattern);

            int counter1 = 0;
            int counter2 = 0;

            foreach (Match match in matches)
            {
                demage += double.Parse(match.ToString());
            }

            string attack = @"[^\/*]";
            //string symbols = Regex.Replace(demon, attack, "");
            foreach (char symbol in demon)
            {
                if (symbol == '*')
                {
                    demage *= 2;
                }
                else if (symbol == '/')
                {
                    demage /= 2;
                }
            }

            return demage;
        }

        public static int GetHealth(string demon)
        {
            string pattern = @"[^0-9\+\-\*\/\.]{1}";
            MatchCollection matches = Regex.Matches(demon, pattern);

            int health = 0;
            foreach (Match match in matches)
            {
                char temp = char.Parse(match.ToString());
                health += (int)temp;
            }

            return health;
        }
    }
}
