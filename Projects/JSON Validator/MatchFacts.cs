using System;
using Xunit;

namespace JSONValidator
{
    public class MatchFacts
    {
        [Fact]
        public void ReturnsProperSuccesState()
        {
            Match matchTrue = new Match("abc", true);
            Assert.True(matchTrue.Succes());
            Match matchFalse = new Match("abc", false);
            Assert.False(matchFalse.Succes());
        }

        [Fact]
        public void ReturnsSameTextIfSuccesIsFalse()
        {
            Match match = new Match("abc", false);
            Assert.Equal("abc", match.RemainingText());
        }

        [Fact]
        public void CanReturnRemainingText()
        {
            Character character = new Character('a');
            IMatch match = character.Match("abcd");
            Assert.Equal("bcd", match.RemainingText());
        }
    }
}
