using System;
using System.Collections.Generic;
using System.Text;

namespace FootbalRanking
{
    class Ranking
    {
        private Team[] ranking;

        public Ranking(Team[] teams)
        {
            this.ranking = teams;
            RankTeams();
        }

        public void AddTeam(Team team)
        {
            Array.Resize(ref ranking, ranking.Length + 1);
            ranking[ranking.Length - 1] = team;
            RankTeams();
        }

        public int GetPosition(Team team)
        {
            for (int i = 0; i < ranking.Length; i++)
            {
                if (ranking[i] == team)
                {
                    return i + 1;
                }
            }

            return -1;
        }

        public Team GetTeamFromPosition(int position)
        {
            return ranking[position - 1];
        }

        public void FootballGame(Team homeTeam, int homeTeamPoints, Team awayTeam, int awayTeamPoints)
        {
            Game game = new Game(homeTeam, homeTeamPoints, awayTeam, awayTeamPoints);
            RankTeams();
        }

        private void RankTeams()
        {
            Team temporaryTeam;
            bool hasSwapped;
            for (int i = 0; i <= ranking.Length - 2; i++)
            {
                hasSwapped = false;
                for (int j = i; j <= ranking.Length - i - 2; j++)
                {
                    if (ranking[j + 1].HasMorePoints(ranking[j]))
                    {
                        temporaryTeam = ranking[j + 1];
                        ranking[j + 1] = ranking[j];
                        ranking[j] = temporaryTeam;
                        hasSwapped = true;
                    }
                }

                if (!hasSwapped)
                {
                    break;
                }
            }
        }
    }
}
