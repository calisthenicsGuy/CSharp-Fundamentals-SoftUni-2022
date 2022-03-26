using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P03.Match_Dates
{
    class Data
    {
        public Data(string day, string month, string year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string dataPattern = @"\b(?<day>\d{2})(\/|.|-)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
                                 //@"\b(\d{2})(\/|.|-)([A-Z][a-z]{2})\2(\d{4})\b"
            //!!!backreference from \2 to \1, because in c# backreference don't count named capture groups for backreferenced!!!
            
            string input = Console.ReadLine();

            MatchCollection matchedData = Regex.Matches(input, dataPattern);

            List<Data> dataes = new List<Data>();
            foreach (Match data in matchedData)
            {
                var day = data.Groups["day"].Value;
                var month = data.Groups["month"].Value;
                var year = data.Groups["year"].Value;
                //var day = data.Groups[1].Value;
                //var month = data.Groups[3].Value;
                //var year = data.Groups[4].Value;

                //Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

                Data newData = new Data(day, month, year);
                dataes.Add(newData);
            }

            foreach (var data in dataes)
            {
                Console.WriteLine($"Day: {data.Day}, Month: {data.Month}, Year: {data.Year}");
            }
        }
    }
}
