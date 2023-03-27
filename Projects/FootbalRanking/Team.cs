using System;
using System.Collections.Generic;
using System.Text;

namespace FootbalRanking
{
    public class Team
    {
        readonly string name;
        private int points;

        public Team(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public Team(string name)
        {
            this.name = name;
            this.points = 0;
        }

        public bool HasMorePoints(Team otherTeam)
        {
            return otherTeam.HasMorePoints(this.points);
        }

        public bool HasMorePoints(int recivedPoints)
        {
            return recivedPoints > points;
        }

        public void AddPoints(int gamePoints)
        {
            this.points += gamePoints;
        }
    }
}
