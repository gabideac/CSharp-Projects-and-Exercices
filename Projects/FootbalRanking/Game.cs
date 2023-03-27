using System;
using System.Collections.Generic;
using System.Text;

namespace FootbalRanking
{
    class Game
    {
        readonly Team homeTeam;
        readonly Team awayTeam;
        readonly int homeTeamScore;
        readonly int awayTeamScore;

        public Game(Team homeTeam, int teamOneScore, Team awayTeam, int awayTeamScore)
        {
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
            this.homeTeamScore = teamOneScore;
            this.awayTeamScore = awayTeamScore;
            AssignPoints();
        }

        private void AssignPoints()
        {
            if (homeTeamScore > awayTeamScore)
            {
                homeTeam.AddPoints(2);
            }
            else if (awayTeamScore > homeTeamScore)
            {
                awayTeam.AddPoints(2);
            }
            else
            {
                homeTeam.AddPoints(1);
                awayTeam.AddPoints(1);
            }
        }
    }
}
