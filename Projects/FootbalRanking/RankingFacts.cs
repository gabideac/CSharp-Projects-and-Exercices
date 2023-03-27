using System;
using Xunit;

namespace FootbalRanking
{
    public class RankingFacts
    {
        [Fact]
        public void MakeRankingOfTwoTeamsAlreadyInOrder()
        {
            Team[] teams = { new Team("CFR CLuj", 20), new Team("U CLuj", 18) };
            Ranking rankingOfTwoTeams = null;
            rankingOfTwoTeams = new Ranking(teams);
            Assert.NotNull(rankingOfTwoTeams);
        }

        [Fact]
        public void CanGetRankingPositionFromTeam()
        {
            Team dinamo = new Team("Dinamo", 19);
            Team[] teams = { new Team("CFR CLuj", 20), dinamo, new Team("U CLuj", 18) };
            Ranking ranking = new Ranking(teams);
            Assert.Equal(2, ranking.GetPosition(dinamo));
            Assert.Equal(-1, ranking.GetPosition(new Team("Steaua", 15)));
        }

        [Fact]
        public void CanGetTeamFromRankingPosition()
        {
            Team dinamo = new Team("Dinamo", 21);
            Team[] teams = { dinamo, new Team("CFR CLuj", 20), new Team("U CLuj", 18) };
            Ranking ranking = new Ranking(teams);
            Assert.Equal(dinamo, ranking.GetTeamFromPosition(1));
        }

        [Fact]
        public void CanCheckIfTwoRankingsAreEqual()
        {
            Team[] teamsOne = { new Team("CFR CLuj", 20), new Team("U CLuj", 18) };
            Team[] teamsTwo = { new Team("CFR CLuj", 20), new Team("U CLuj", 18) };
            Ranking rankingOne = new Ranking(teamsOne);
            Ranking rankingTwo = new Ranking(teamsTwo);
            Assert.Equal(rankingOne.GetPosition(new Team("CFR CLuj", 20)), rankingTwo.GetPosition(new Team("CFR CLuj", 20)));
            Assert.Equal(rankingOne.GetPosition(new Team("U CLuj", 18)), rankingTwo.GetPosition(new Team("U CLuj", 18)));
        }

        [Fact]
        public void RanksTeams()
        {
            Team[] teams = { new Team("CFR CLuj", 20), new Team("U CLuj", 18), new Team("Dinamo", 22) };
            Team[] teamsAlreadyRanked = { new Team("Dinamo", 22), new Team("CFR CLuj", 20), new Team("U CLuj", 18) };
            Ranking rankingOne = new Ranking(teams);
            Ranking rankingTwo = new Ranking(teamsAlreadyRanked);
            Assert.Equal(rankingOne.GetPosition(new Team("Dinamo", 22)), rankingTwo.GetPosition(new Team("Dinamo", 22)));
        }

        [Fact]
        public void CanAddTeamAndPlaceItOnProperPosition()
        {
            Team[] teams = { new Team("CFR CLuj", 20), new Team("U CLuj", 18) };
            Team[] teamsAlreadyRanked = { new Team("CFR CLuj", 20), new Team("Dinamo", 19), new Team("U CLuj", 18) };
            Ranking rankingOne = new Ranking(teams);
            Ranking rankingTwo = new Ranking(teamsAlreadyRanked);
            rankingOne.AddTeam(new Team("Dinamo", 19));
            Assert.Equal(rankingOne.GetPosition(new Team("Dinamo", 19)), rankingTwo.GetPosition(new Team("Dinamo", 19)));
        }

        [Fact]
        public void RankingUpdatesAfterGame()
        {
            Team dinamo = new Team("Dinamo", 20);
            Team ucj = new Team("U CLuj", 19);
            Team[] teams = { dinamo, ucj, new Team("CFR CLuj", 18) };
            Ranking ranking = new Ranking(teams);
            ranking.FootballGame(dinamo, 2, ucj, 3);
            Assert.Equal(ucj, ranking.GetTeamFromPosition(1));
        }
    }
}
