using FootaballLeague;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    public class Matches
    {
        public Matches(Teams team1, Teams team2, int goalsTeam1, int goalsTeam2)
        {
            home = team1;
            away = team2;
            team1.UpdateState(goalsTeam1, goalsTeam2);
            team2.UpdateState(goalsTeam2, goalsTeam1);
        }

        public Teams home { get; set; }
        public Teams away { get; set; }

        public void GetResult()
        {
            if (home.GoalsScored > away.GoalsScored)
            {
                home.Won++;
                away.lost++;
            }
            else if (home.GoalsScored < away.GoalsScored)
            {
                away.Won++;
                home.lost++;
            }
            else
            {
                home.Draw++;
                away.Draw++;
            }

            home.totalMacth++;
            away.totalMacth++;
        }
    }
}
