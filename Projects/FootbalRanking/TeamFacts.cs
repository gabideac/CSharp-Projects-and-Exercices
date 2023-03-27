using System;
using Xunit;

namespace FootbalRanking
{
    public class TeamFacts
    {
        [Fact]
        public void CanCreateATeam()
        {
            Team team = null;
            team = new Team("U Cluj", 20);
            Assert.NotNull(team);
        }

        [Fact]
        public void CanCreateATeamOnlyByName()
        {
            Team team = null;
            team = new Team("U Cluj");
            Assert.NotNull(team);
        }

        [Fact]
        public void CanCheckIfTwoTeamsAreEqual()
        {
            Team teamOne = new Team("U Cluj", 0);
            Team teamTwo = new Team("U Cluj");
            Assert.False(teamOne.HasMorePoints(teamTwo));
            Assert.False(teamTwo.HasMorePoints(teamOne));
        }

        [Fact]
        public void CanAddPointsToTeam()
        {
            Team teamOne = new Team("CFR Cluj", 1);
            Team teamTwo = new Team("U Cluj");
            teamTwo.AddPoints(2);
            Assert.True(teamTwo.HasMorePoints(teamOne));
        }
    }
}
