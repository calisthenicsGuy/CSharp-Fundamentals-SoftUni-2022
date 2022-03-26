using System;
using System.Text;

namespace P04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            foreach (char character in input)
            {
                int temp = (int)character + 3;
                sb.Append((char)temp);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
