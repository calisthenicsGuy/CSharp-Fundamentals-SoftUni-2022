using System;

namespace P09.Greater_of_Two_Values
{
    class Program
    {
        public static void GetMaxOfChar()
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());

            if (symbol1 >= symbol2)
            {
                Console.WriteLine(symbol1);
            }
            else
            {
                Console.WriteLine(symbol2);
            }
        }
        
        public static void GetMaxOfInt()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (number1 >= number2)
            {
                Console.WriteLine(number1);
            }
            else
            {
                Console.WriteLine(number2);
            }
        }

        public static void GetMaxOfString()
        {
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();
            if (String.Compare(text1, text2) >= 0)
            {
                Console.WriteLine(text1);
            }
            else
            {
                Console.WriteLine(text2);
            }
        }

        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                GetMaxOfInt();
            }
            else if (type == "string")
            {
                GetMaxOfString();
            }
            else if (type == "char")
            {
                GetMaxOfChar();
            }
        }
    }
}
