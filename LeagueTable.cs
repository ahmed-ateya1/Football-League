using FootballLeague;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootaballLeague
{
    public class LeagueTable
    {
        private HashSet<Teams> teams;
        public string WinnerTeams {  get; set; }

        public LeagueTable()
        {
            teams = new HashSet<Teams>();
        }

        public void AddTeam(Teams team)
        { 
            teams.Add(team);
        }
        public void AddMatchResult(Matches match)
        {
            match.GetResult();
        }
        public void DisplayTable()
        {
            Console.WriteLine("League Table:");
            Console.WriteLine("-------------------");
            Console.WriteLine("Team Name\t       Played \t        Won \t   Drawn \t" +
                "      Lost \t Goals Scored \t    Goals Conceded " +
                "\t Points ");
            Console.WriteLine("--------------------------------------------------------------------------------------" +
                "-----------------------------------------------");
            int cnt = 0;
            foreach (var team in teams.OrderByDescending(t => t.Points))
            {
                if(cnt == 0)
                    WinnerTeams = team.TeamName;
                cnt++;
                Console.WriteLine($"{team.TeamName}\t\t" +
                    $" {team.totalMacth}\t\t" +
                    $" {team.Won}\t\t" +
                    $"{team.Draw}\t\t" +
                    $"{team.lost}\t\t" +
                    $"{team.GoalsScored}\t\t" +
                    $" {team.GoalsConceded}\t\t" +
                    $"  {team.Points}\t\t");
                Console.WriteLine("--------------------------------------------------------------------------------------" +
               "-----------------------------------------------");
            }
            
        }

    }
}
