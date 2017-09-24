using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        SortedDictionary<string, int> teamWins = new SortedDictionary<string, int>();
        SortedDictionary<string, List<string>> teamsOpponents = new SortedDictionary<string, List<string>>();

        string[] input = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        int goalsFirstTeam;
        int goalsSecondTeam ;
        while (input[0] != "stop")
        {
            int[] firstResult = input[2].Split(':').Select(int.Parse).ToArray();
            int[] secondResult = input[3].Split(':').Select(int.Parse).ToArray();
            string teamOne = input[0].Trim();
            string teamTwo = input[1].Trim();
            goalsFirstTeam = firstResult[0] + secondResult[1];
            goalsSecondTeam = firstResult[1] + secondResult[0];
            if (!teamsOpponents.ContainsKey(teamOne))
            {
                teamsOpponents.Add(teamOne, new List<string>());
                teamsOpponents[teamOne].Add(teamTwo);
            }
            else
            {
                teamsOpponents[teamOne].Add(teamTwo);
            }
            if (!teamsOpponents.ContainsKey(teamTwo))
            {
                teamsOpponents.Add(teamTwo, new List<string>());
                teamsOpponents[teamTwo].Add(teamOne);
            }
            else
            {
                teamsOpponents[teamTwo].Add(teamOne);
            }
            if (goalsFirstTeam > goalsSecondTeam)
            {
                if (!teamWins.ContainsKey(teamTwo))
                {
                    teamWins.Add(teamTwo, 0);
                }
                if (!teamWins.ContainsKey(teamOne))
                {
                    teamWins.Add(teamOne, 0);
                }
                if (teamWins.ContainsKey(teamOne))
                {
                    teamWins[teamOne] += 1;//one more win  
                }

            }
            else if (goalsSecondTeam > goalsFirstTeam)
            {
                if (!teamWins.ContainsKey(teamOne))
                {
                    teamWins.Add(teamOne, 0);
                }
                if (!teamWins.ContainsKey(teamTwo))
                {
                    teamWins.Add(teamTwo, 1);
                }
                else
                {
                    teamWins[teamTwo] += 1;//one more win for team two
                }
            }
            else if (goalsFirstTeam == goalsSecondTeam)//we calculate away goals of teams
            {
                if (secondResult[1] > firstResult[1])//we add second team as winner
                {
                    if (!teamWins.ContainsKey(teamTwo))
                    {
                        teamWins.Add(teamTwo, 0);
                    }
                    if (!teamWins.ContainsKey(teamOne))
                    {
                        teamWins.Add(teamOne, 1);
                    }
                    else
                    {
                        teamWins[teamOne] += 1;
                    }
                }
                else//we add first team as winner
                {
                    if (!teamWins.ContainsKey(teamOne))
                    {
                        teamWins.Add(teamOne, 0);
                    }
                    if (!teamWins.ContainsKey(teamTwo))
                    {
                        teamWins.Add(teamTwo, 1);
                    }
                    else
                    {
                        teamWins[teamTwo] += 1;
                    }
                }
            }

            input = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

        foreach (var team in teamWins.OrderByDescending(w => w.Value).ThenBy(t => t.Key))
        {
            Console.WriteLine(team.Key);
            Console.WriteLine("- Wins: " + team.Value);
            foreach (var opponent in teamsOpponents.Where(t => t.Key == team.Key).OrderBy(opponent => opponent.Value))
            {
                Console.Write("- Opponents: ");
                string print = "";
                foreach (var teamOpponenst in opponent.Value.OrderBy(t => t))
                {
                    print += teamOpponenst + ", ";
                }
                Console.Write(print.Substring(0, print.Length - 2));
                Console.WriteLine();
            }
        }
    }
}

