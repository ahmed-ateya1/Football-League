using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootaballLeague
{
    public class Teams
    {
        public Teams(string teamName)
        {
            TeamName = teamName.PadRight(15,' ');
            Points = 0;
            GoalsScored = 0;
            GoalsConceded = 0;
            Won = 0;
            Draw = 0;
            lost = 0;
            totalMacth = 0;
            TotalGoalsScored = 0;
            TotalGoalsConceded= 0;
        }

        public string TeamName { get; set; }
        public int Points { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsConceded { get; set; }
        public int TotalGoalsScored { get; set; }
        public int TotalGoalsConceded { get; set; }
        public int Won {  get; set; }
        public int Draw {  get; set; }
        public int lost { get; set; }
        public int totalMacth {  get; set; }
        public void UpdateState(int goalsScored1, int goalsConceded1)
        {
            TotalGoalsScored += goalsScored1;
            TotalGoalsScored += goalsConceded1;
            GoalsScored = goalsScored1;
            GoalsConceded = goalsConceded1;
            if (goalsScored1 > goalsConceded1)
            {
                Points += 3;
            }
            else if (goalsScored1 == goalsConceded1)
            {
                Points += 1;
            }
        }
    }
}
