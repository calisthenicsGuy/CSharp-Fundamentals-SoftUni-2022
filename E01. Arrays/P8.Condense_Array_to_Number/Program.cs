using System;
using System.Linq;

namespace P8.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mainArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] condenseArray = new int[mainArray.Length - 1];

            if (mainArray.Length == 1)
            {
                Console.WriteLine(mainArray[0]);
                return;
            }

            for (int i = 0; i < mainArray.Length; i++)
            {
                for (int j = 0; j < condenseArray.Length - i; j++)
                {
                    condenseArray[j] = mainArray[j] + mainArray[j + 1];
                }
                mainArray = condenseArray;
            }

            Console.WriteLine(condenseArray[0]);
        }
    }
}
