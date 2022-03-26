using System;
using System.Linq;

namespace P09.Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int counter = 1;
            int bestSequenceIndex = 1;
            int bestSequenceQueue = 0;
            int bestSequenceStartIndex = 0;
            int[] bestArray = new int[length];

            string command;
            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int[] array = command
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int tempBestSequenceQueue = 0;
                int tempBestSequenceStartIndex = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    int tempInTempBestSequenceQueue = 0;
                    for (int j = i; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            tempInTempBestSequenceQueue++;
                        }
                    }
                    if (tempInTempBestSequenceQueue > tempInTempBestSequenceQueue)
                    {
                        tempInTempBestSequenceQueue = bestSequenceIndex;
                        tempBestSequenceStartIndex = i;
                    }

                    if (tempBestSequenceQueue == bestSequenceQueue)
                    {
                        if (tempBestSequenceStartIndex < bestSequenceIndex)
                        {
                            bestSequenceIndex = tempBestSequenceStartIndex;
                        }
                        else if (tempBestSequenceStartIndex == bestSequenceIndex)
                        {
                            if (bestArray.Sum() < array.Sum())
                            {
                                bestSequenceIndex = counter;
                                bestArray = array;
                            }
                        }
                    }
                    else if (tempBestSequenceQueue > bestSequenceQueue)
                    {
                        bestSequenceQueue = tempBestSequenceQueue;
                        bestSequenceIndex = tempBestSequenceStartIndex;
                        bestArray = array;
                        bestSequenceIndex = counter;
                    }
                }

                counter++;
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestArray.Sum()}.");
            Console.WriteLine(string.Join(" ", bestArray));
        }
    }
}
