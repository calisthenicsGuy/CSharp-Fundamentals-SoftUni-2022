using System;
using System.Linq;

namespace P04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            RotatingArray(array);
        }
        private static void RotatingArray(int[] array)
        {
            int countOfRotations = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countOfRotations; i++)
            {
                int temp = array[0]; // 51  |  47
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1]; // 47, 32, 61, 21  |  32, 61, 21, 52, 
                }
                array[array.Length - 1] = temp; // 47, 32, 61, 21, 52  |  32, 61, 21, 52, 47
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
