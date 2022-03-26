using System;

namespace P04.Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            CheckIfPasswordIsValid(password);
        }

        private static void CheckIfPasswordIsValid(string password)
        {
            bool isContainsNeededCharacters = password.Length >= 6 && password.Length <= 10;
            bool isOnlyLettersOrDigit = true;

            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                char temp = password[i];
                if (!char.IsLetterOrDigit(temp))
                {
                    isOnlyLettersOrDigit = false;
                }
                if (char.IsDigit(temp))
                {
                    counter++;
                }
            }

            bool isContainsAtLeastTwoDigit = counter >= 2;


            if (!isContainsNeededCharacters)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isOnlyLettersOrDigit)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isContainsAtLeastTwoDigit)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isContainsAtLeastTwoDigit && isContainsNeededCharacters && isOnlyLettersOrDigit)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
