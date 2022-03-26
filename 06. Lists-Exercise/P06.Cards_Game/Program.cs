using System;
using System.Linq;

namespace P06.Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPlayer = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var secondPlayer = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                if (firstPlayer[0] > secondPlayer[0])
                {
                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.Add(secondPlayer[0]);
                }
                else if (secondPlayer[0] > firstPlayer[0])
                {
                    secondPlayer.Add(secondPlayer[0]);
                    secondPlayer.Add(firstPlayer[0]);
                }
                firstPlayer.Remove(firstPlayer[0]);
                secondPlayer.Remove(secondPlayer[0]);

                if (firstPlayer.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
                    break;
                }
                else if (secondPlayer.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
                    break;
                }
            }
        }
    }
}
