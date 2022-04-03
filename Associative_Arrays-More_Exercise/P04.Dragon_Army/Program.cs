using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Dragon> dragons = new List<Dragon>();

            for (int i = 0; i < n; i++)
            {
                string[] parameters = Console.ReadLine().Split(' ');
                double value = 0;

                Dragon dragon = new Dragon()
                {
                    Type = parameters[0],
                    Name = parameters[1],
                    Damage = double.TryParse(parameters[2], out value) ? value : 45,
                    Health = double.TryParse(parameters[3], out value) ? value : 250,
                    Armour = double.TryParse(parameters[4], out value) ? value : 10,
                };

                Dragon existingDragon = dragons.SingleOrDefault(d => d.Name == dragon.Name && d.Type == dragon.Type);
                if (existingDragon != null)
                {
                    existingDragon.Damage = dragon.Damage;
                    existingDragon.Health = dragon.Health;
                    existingDragon.Armour = dragon.Armour;
                }
                else
                {
                    dragons.Add(dragon);
                }
            }

            var groupedDragons = dragons.GroupBy(
                d => d.Type,
                d => d,
                (key, d) =>
                    new GroupedDragon()
                    {
                        Type = key,
                        Dragons = d.ToList()
                    });

            foreach (GroupedDragon groupedDragon in groupedDragons)
            {
                int dragonCount = groupedDragon.Dragons.Count;
                double damage = groupedDragon.Dragons.Sum(d => d.Damage) / dragonCount;
                double health = groupedDragon.Dragons.Sum(d => d.Health) / dragonCount;
                double armour = groupedDragon.Dragons.Sum(d => d.Armour) / dragonCount;

                Console.WriteLine($"{groupedDragon.Type}::({damage:F2}/{health:F2}/{armour:F2})");

                foreach (Dragon dragon in groupedDragon.Dragons.OrderBy(d => d.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armour}");
                }
            }
        }
    }

    class Dragon
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public double Damage { get; set; }
        public double Health { get; set; }
        public double Armour { get; set; }
    }

    class GroupedDragon
    {
        public string Type { get; set; }
        public List<Dragon> Dragons { get; set; }
    }
}
