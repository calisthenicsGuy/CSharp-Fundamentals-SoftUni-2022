using System;

namespace P09.Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Palindrome(command);
        }

        private static void Palindrome(string command)
        {
            while (command != "END")
            {
                bool isPalindrome = true;
                for (int i = 0; i < command.Length; i++)
                {
                    if (!(command[i] == command[command.Length - i - 1]))
                    {
                        isPalindrome = false;
                        Console.WriteLine("false");
                        break;
                    }
                }

                if (isPalindrome)
                {
                    Console.WriteLine("true");

                }

                command = Console.ReadLine();
            }
        }
    }
}
