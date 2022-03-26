using System;
using System.Linq;

namespace P03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int[] array1 = new int[lines];
            int[] array2 = new int[lines];

            bool isShouldTakeFirst = true;
            for (int i = 0; i < lines; i++)
            {
                int[] tempArray = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (isShouldTakeFirst)
                {
                    array1[i] = tempArray[0];
                    array2[i] = tempArray[1];
                    isShouldTakeFirst = false;
                }
                else if (!isShouldTakeFirst)
                {
                    array1[i] = tempArray[1];
                    array2[i] = tempArray[0];
                    isShouldTakeFirst = true;
                }
            }

            Console.WriteLine(string.Join(" ", array1));
            Console.WriteLine(string.Join(" ", array2));
        }
    }
}
