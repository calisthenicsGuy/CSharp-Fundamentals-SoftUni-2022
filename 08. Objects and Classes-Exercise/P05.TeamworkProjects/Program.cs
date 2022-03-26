using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.TeamworkProjects
{
    class Team
    {
        public Team(string creator, string teamName)
        {
            this.Creator = creator;
            this.TeamName = teamName;
            this.Members = new List<string>();
        }

        public void AddMember(string member)
        {
            this.Members.Add(member);
        }

        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            TeamRegister(teams);
            JoinMembers(teams);
            PrintTeams(teams);

        }

        public static void TeamRegister(List<Team> teams)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] teamRegister = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string creator = teamRegister[0];
                string teamName = teamRegister[1];

                if (teams.Any(name => name.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Any(user => user.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team newTeam = new Team(creator, teamName);
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }
        }

        public static void JoinMembers(List<Team> teams)
        {
            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] addMembersArgs = command
                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string member = addMembersArgs[0];
                string teamNameToJoin = addMembersArgs[1];

                Team searchedTeam = teams.FirstOrDefault(t => t.TeamName == teamNameToJoin);
                if (searchedTeam == null)
                {
                    Console.WriteLine($"Team {teamNameToJoin} does not exist!");
                    continue;
                }
                if (teams.Any(m => m.Members.Contains(member)))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamNameToJoin}!");
                    continue;
                }
                if (teams.Any(c => c.Creator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamNameToJoin}!");
                    continue;
                }

                searchedTeam.AddMember(member);
            }
        }

        public static void PrintTeams(List<Team> teams)
        {
            List<Team> validTeams = teams
                .Where(t => t.Members.Count != 0)
                .OrderByDescending(m => m.Members.Count)
                .ThenBy(n => n.TeamName)
                .ToList();

            List<Team> invalidTeams = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(n => n.TeamName)
                .ToList();

            foreach (Team team in validTeams)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team invalidTeam in invalidTeams)
            {
                Console.WriteLine(invalidTeam.TeamName);
            }
        }
    }
}
