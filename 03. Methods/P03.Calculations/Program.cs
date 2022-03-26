using System;

namespace P03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintOperationBetweenTwoNumbers(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), 0);
        }

        public static void PrintOperationBetweenTwoNumbers(string typeOfOperation, int num1, int num2, int finalResult)
        {
            if (typeOfOperation == "add")
            {
                finalResult = num1 + num2;
            }
            else if (typeOfOperation == "multiply")
            {
                finalResult = num1 * num2;
            }
            else if (typeOfOperation == "subtract")
            {
                finalResult = num1 + -num2;
            }
            else if (typeOfOperation == "divide")
            {
                finalResult = num1 / num2;
            }
            Console.WriteLine(finalResult);
        }
    }
}
