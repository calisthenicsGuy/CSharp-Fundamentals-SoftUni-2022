using System;

namespace P05.Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintSum(firstNum, secondNum, thirdNum));
        }

        private static int PrintSum(int firstNum, int secondNum, int thirdNum)
        {
            int result = (firstNum + secondNum) - thirdNum;
            return result;
        }
    }
}
