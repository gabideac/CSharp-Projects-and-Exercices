using System;
using Xunit;

namespace FootbalRanking
{
    public class GameFacts
    {
        [Fact]
        public void CreateAGame()
        {
            Game gameUVersusCFR = null;
            gameUVersusCFR = new Game(new Team("U Cluj", 15), 2, new Team("CFR Cluj", 16), 1);
            Assert.NotNull(gameUVersusCFR);
        }

        [Fact]
        public void AddsPointsOnlyToWinner()
        {
            Team ucluj = new Team("U Cluj", 15);
            Team cfrCluj = new Team("CFR Cluj", 16);
            Game gameUVersusCFR = new Game(ucluj, 3, cfrCluj, 1);
            Assert.True(ucluj.HasMorePoints(cfrCluj));
        }

        [Fact]
        public void AddsPointsToBothTeamsGameIsDraw()
        {
            Team noGameUCluj = new Team("U Cluj", 15);
            Team noGameCfrCluj = new Team("CFR Cluj", 16);
            Team ucluj = new Team("U Cluj", 15);
            Team cfrCluj = new Team("CFR Cluj", 16);
            Game gameUVersusCFR = new Game(ucluj, 1, cfrCluj, 1);
            Assert.True(ucluj.HasMorePoints(noGameUCluj));
            Assert.True(cfrCluj.HasMorePoints(noGameCfrCluj));
        }
    }
}
