using System;
using System.Linq;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Taks_Heroes_of_Code_and_Logic_VII
{
    class Hero
    {
        public Hero(int hp, int mp)
        {
            this.HitPoints = hp;
            this.ManaPoints = mp;
        }
            
        public int HitPoints { get; set; }
        public int ManaPoints { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Hero> heros = new Dictionary<string, Hero>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] herosInformation = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = herosInformation[0];
                int hitPoints = int.Parse(herosInformation[1]);
                int manaPoints = int.Parse(herosInformation[2]);

                if (hitPoints > 100)
                {
                    hitPoints = 100;
                }
                if (manaPoints > 200)
                {
                    manaPoints = 200;
                }

                Hero newHero = new Hero(hitPoints, manaPoints);
                heros.Add(name, newHero);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string action = commandArgs[0];
                string name = commandArgs[1];

                if (action == "CastSpell")
                {
                    int mpNeeded = int.Parse(commandArgs[2]);
                    string spellName = commandArgs[3];

                    if (heros[name].ManaPoints >= mpNeeded)
                    {
                        heros[name].ManaPoints -= mpNeeded;
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {heros[name].ManaPoints} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(commandArgs[2]);
                    string attacker = commandArgs[3];

                    heros[name].HitPoints -= damage;

                    if (heros[name].HitPoints > 0)
                    {
                        Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heros[name].HitPoints} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                        heros.Remove(name);
                    }
                }
                else if (action == "Recharge")
                {
                    int amount = int.Parse(commandArgs[2]);
                    heros[name].ManaPoints += amount;

                    if (heros[name].ManaPoints > 200)
                    {
                        amount = 200 - (heros[name].ManaPoints - amount);
                        heros[name].ManaPoints = 200;
                    }

                    Console.WriteLine($"{name} recharged for {amount} MP!");
                }
                else if (action == "Heal")
                {
                    int amount = int.Parse(commandArgs[2]);
                    heros[name].HitPoints += amount;

                    if (heros[name].HitPoints > 100)
                    {
                        amount = 100 - (heros[name].HitPoints - amount);
                        heros[name].HitPoints = 100;
                    }

                    Console.WriteLine($"{name} healed for {amount} HP!");
                }
            }

            foreach (KeyValuePair<string, Hero> hero in heros
                .OrderByDescending(h => h.Value.HitPoints).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"  HP: {hero.Value.HitPoints}");
                Console.WriteLine($"  MP: {hero.Value.ManaPoints}");
            }
        }
    }
}
