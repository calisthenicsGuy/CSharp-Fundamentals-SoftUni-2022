using System;
using System.Linq;

namespace P06.Equa__Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            EquelSum(array);
        }

        private static void EquelSum(int[] array)
        {
            // 10 5 5 99 3 4 2 5 1 1 4
            if (array.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }

                for (int k = i + 1; k < array.Length; k++)
                {
                    rightSum += array[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
