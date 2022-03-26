using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace P05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // 325
            // 5
            //-------
            // 1625
            string bigNum = Console.ReadLine(); // 325
            int singleDigit = int.Parse(Console.ReadLine()); // 5
            StringBuilder finalResult = new StringBuilder(); // 0

            if (singleDigit == 0 || bigNum == "0")
            {
                Console.WriteLine("0");
                return;
            }

            int reminder = 0;
            for (int i = bigNum.Length-1; i >= 0; i--)
            {
                int currentDigit = int.Parse(bigNum[i].ToString()); // 5
                int currentResult = currentDigit * singleDigit + reminder; // 25
                int finalCurrentResult = currentResult % 10; //25%10=5
                finalResult.Insert(0, finalCurrentResult);
                
                reminder = currentResult / 10; // 25/10=2
            }

            if (reminder > 0)
            {
                finalResult.Insert(0, reminder);
            }

            Console.WriteLine(finalResult.ToString());
        }
    }
}
