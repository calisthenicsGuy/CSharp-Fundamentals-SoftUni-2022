using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> courses = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> competitors = new Dictionary<string, Dictionary<string, int>>();

            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] contestInfo = input
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string contest = contestInfo[0];
                string contestPassword = contestInfo[1];

                courses[contest] = contestPassword;
            }

            int bestCandidateScore = 0;
            input = null;
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] competitorsInfo = input
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string contest = competitorsInfo[0];
                string password = competitorsInfo[1];
                string username = competitorsInfo[2];
                int points = int.Parse(competitorsInfo[3]);

                if (!courses.ContainsKey(contest))
                {
                    continue;
                }
                if (courses[contest] != password)
                {
                    continue;
                }

                if (competitors.ContainsKey(username) && competitors[username].ContainsKey(contest))
                {
                    if (points > competitors[username][contest])
                    {
                        competitors[username][contest] = points;
                    }
                    continue;
                }

                if (!competitors.ContainsKey(username))
                {
                    competitors[username] = new Dictionary<string, int>();
                }
                competitors[username].Add(contest, points);
            }

            string bestCandidateName = null;
            int bestScore = 0;

            BestCandidate(bestCandidateName, bestScore, competitors);
            Output(competitors, bestCandidateName, bestScore);
        }

        private static void BestCandidate(string bestCandidateName, int bestScore, Dictionary<string, Dictionary<string, int>> competitors)
        {
            foreach (var competitor in competitors.OrderBy(n => n.Key))
            {
                int tempBestPoints = 0;
                foreach (var competitorScore in competitor.Value.OrderByDescending(p => p.Value))
                {
                    tempBestPoints += competitorScore.Value;
                }

                if (tempBestPoints > bestScore)
                {
                    bestScore = tempBestPoints;
                    bestCandidateName = competitor.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidateName} with total {bestScore} points.");
        }

        public static void Output(Dictionary<string, Dictionary<string, int>> competitors, string bestCandidateName, int bestScore)
        {
            Console.WriteLine("Ranking: ");
            foreach (var competitor in competitors.OrderBy(n => n.Key))
            {
                Console.WriteLine(competitor.Key);
                foreach (var competitorScore in competitor.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"#  {competitorScore.Key} -> {competitorScore.Value}");
                }
            }
        }
    }
}
