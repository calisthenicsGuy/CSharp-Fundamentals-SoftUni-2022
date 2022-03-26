using System;
using System.Linq;

namespace P7.Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] array2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int differenceIndex = 0;

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];

                if (array[i] != array2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
