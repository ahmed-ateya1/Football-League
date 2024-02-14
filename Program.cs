using FootaballLeague;
using System;
using System.Collections.Generic;

namespace FootballLeague
{
    
    internal class Program
    {
        static void Interface()
        {
            List<Teams> teams = new List<Teams>() {
                new Teams("Real Madried") ,
                new Teams("Alahly") ,
                new Teams("Barcalona"),
                //new Teams("Al Hilal"),
                //new Teams("Ismalie"),
                new Teams("LivePool"),
                //new Teams("Man City")
            };
            List<string> matches = new List<string>();
            Random rnd = new Random();
            LeagueTable leagueTable = new LeagueTable();
            for (int i = 0; i < teams.Count - 1; i++)
            {
                for (int j = i + 1; j < teams.Count; j++)
                {
                    leagueTable.AddTeam(teams[i]);
                    leagueTable.AddTeam(teams[j]);
                    int x, y;
                    Console.WriteLine($"{teams[i].TeamName} VS {teams[j].TeamName}");
                    x = int.Parse(Console.ReadLine());
                    y = int.Parse(Console.ReadLine());
                    Matches match = new Matches(teams[i], teams[j], x, y);
                    leagueTable.AddMatchResult(match);
                    matches.Add($"{teams[i].TeamName} : {teams[j].TeamName}");
                }
            }
            Console.WriteLine();
            leagueTable.DisplayTable();
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("The club that wins the Champions League is: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(leagueTable.WinnerTeams);
        }
        public static void Test()
        {
            List<string> teams = new List<string>() { "Real Madrid", "Barcelona", "Man City", "Man United" };
            List<string> matches = new List<string>();

            Random rnd = new Random();
            for (int i = 0; i < teams.Count - 1; i++)
            {
                for (int j = i + 1; j < teams.Count; j++)
                {
                    matches.Add($"{teams[i]} : {teams[j]}");
                }
            }


            for (int i = matches.Count - 1; i > 0; i--)
            {
                int randomIndex = rnd.Next(0, i + 1);
                string temp = matches[i];
                matches[i] = matches[randomIndex];
                matches[randomIndex] = temp;
            }

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
        static void Main(string[] args)
        {
            Interface();
            Console.ReadKey();
        }
    }
}
