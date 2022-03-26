using System;
using System.Linq;

namespace P07.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxSequence = 0;
            int longestElement = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int tempMaxSequence = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        tempMaxSequence++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (tempMaxSequence > maxSequence)
                {
                    maxSequence = tempMaxSequence;
                    longestElement = nums[i];
                }
            }
            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write($"{longestElement} ");
            }
        }
    }
}
