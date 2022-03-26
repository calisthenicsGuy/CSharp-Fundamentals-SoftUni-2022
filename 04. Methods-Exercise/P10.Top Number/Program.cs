using System;

namespace P10.Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            TopNumbers(n);
        }

        private static void TopNumbers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                bool isContainsAtLeasOneOddDigit = false;

                int sumOfDigits = 0;
                int temp = i;
                int temp1 = i;

                while (temp1 != 0)
                {
                    temp = temp1 % 10;
                    if (temp % 2 == 1)
                    {
                        isContainsAtLeasOneOddDigit = true;
                    }
                    sumOfDigits += temp;
                    temp1 /= 10;
                }

                if (sumOfDigits % 8 == 0 && isContainsAtLeasOneOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
