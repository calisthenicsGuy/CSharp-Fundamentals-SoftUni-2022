using System;

namespace P03.Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());

            CharactersInRange(symbol1, symbol2);
        }

        private static void CharactersInRange(char symbol1, char symbol2)
        {
            if (symbol2 < symbol1)
            {
                char temp = symbol1;
                symbol1 = symbol2;
                symbol2 = temp;
            }

            for (int i = (int)symbol1 + 1; i < symbol2; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
