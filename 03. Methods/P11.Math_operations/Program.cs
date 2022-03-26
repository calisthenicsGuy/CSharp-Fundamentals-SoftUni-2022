using System;

namespace P11.Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            MathOperations(a, b, operation);
        }

        private static void MathOperations(int a, int b, string operation)
        {
            if (operation == "+")
            {
                Console.WriteLine(a + b);
            }
            else if (operation == "*")
            {
                Console.WriteLine(a * b);
            }
            else if (operation == "-")
            {
                Console.WriteLine(a - b);
            }
            else if (operation == "/")
            {
                Console.WriteLine(a / b);
            }
        }
    }
}
