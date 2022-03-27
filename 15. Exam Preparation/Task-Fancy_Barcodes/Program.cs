using System;
using System.Text.RegularExpressions;

namespace Task_Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string barcodePattern = @"(@#+){1}(?<name>[A-Z]{1}[A-Za-z0-9]+[A-Z]{1})(@#+){1}";
            string digitPattern = @"\d";

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string barcode = Console.ReadLine();
                Match match = Regex.Match(barcode, barcodePattern);

                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                barcode = match.Groups["name"].Value;

                MatchCollection matchesDigits = Regex.Matches(barcode, digitPattern);
                string productGroup = string.Empty;

                foreach (Match m in matchesDigits)
                {
                    if (m.Success)
                    {
                        productGroup += m.Value;
                    }
                }

                if (productGroup.Length == 0)
                {
                    productGroup = "00";
                }
                
                Console.WriteLine($"Product group: {productGroup}");
            }
        }
    }
}
