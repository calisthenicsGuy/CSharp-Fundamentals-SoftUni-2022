using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace P04.Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            string validMessagePattern =
                @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?\:(\d+)[^\@\-\!\:\>]*?\!(?<attackType>A|D){1}\![^\@\-\!\:\>]*?\-\>(\d+)";
            
            /*\@(?< planet >[A - Za - z] +)([^\@\-\!\:\>] *?)
            :(?< population >\d +)([^\@\-\!\:\>] *?)
            \!(?< attackType > A | D){ 1}\!([^\@\-\!\:\>] *?)
            \-\> (\d +)*/

            int n = int.Parse(Console.ReadLine());
            DecryptingProcess(n, attackedPlanets, destroyedPlanets, validMessagePattern);
        }

        public static void DecryptingProcess
            (int n, List<string> attackedPlanets, List<string> destroyedPlanets, string validMessagePattern)
        {
            for (int i = 1; i <= n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMessage = DecryptedMessage(encryptedMessage);

                Match match = Regex.Match(decryptedMessage, validMessagePattern);

                if (match.Success)
                {
                    string planet = match.Groups["planet"].Value;
                    string attackType = match.Groups["attackType"].Value;

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planet);
                    }

                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
            }

            PrintingOutput(attackedPlanets, destroyedPlanets);
        }

        public static void PrintingOutput(List<string> attackedPlanets, List<string> destroyedPlanets)
        {
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (string attackedPlanet in attackedPlanets.OrderBy(n => n))
            {
                Console.WriteLine($"-> {attackedPlanet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (string destroyedPlanet in destroyedPlanets.OrderBy(n => n))
            {
                Console.WriteLine($"-> {destroyedPlanet}");
            }
        }

        public static string DecryptedMessage(string encryptedMessage)
        {
            StringBuilder decryptedMessage = new StringBuilder();
            int decryptionKey = DecryptedKeyValue(encryptedMessage);

            foreach (char currCh in encryptedMessage)
            {
                char decryptedCh = (char)(currCh - decryptionKey);
                decryptedMessage.Append(decryptedCh);
            }

            return decryptedMessage.ToString();
        }

        public static int DecryptedKeyValue(string encryptedMessage)
        {
            string decryptPattern = "[star]{1}";
            MatchCollection matches =
                Regex.Matches(encryptedMessage, decryptPattern, RegexOptions.IgnoreCase);

            return matches.Count;
        }
    }
}