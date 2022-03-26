using System;
using System.Linq;

namespace P01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (string username in usernames)
            {
                if (IsValidUsername(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        private static bool IsValidUsername(string username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }
            for (int i = 0; i < username.Length; i++)
            {
                if (!char.IsLetterOrDigit(username[i]) && username[i] != '-' && username[i] != '_')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
