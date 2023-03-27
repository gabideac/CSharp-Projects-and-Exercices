using System;
using Xunit;

namespace JSONValidator
{
    public class RangeFacts
    {
        [Fact]
        public void SingleCharacterIsWithinRange()
        {
            Range range = new Range('a', 'c');
            IMatch match = range.Match("b");
            Assert.True(match.Succes());
        }

        [Fact]
        public void InputCantBeNull()
        {
            Range range = new Range('a', 'c');
            IMatch match = range.Match(null);
            Assert.False(match.Succes());
        }

        [Fact]
        public void InputCantBeEmpty()
        {
            Range range = new Range('a', 'c');
            IMatch match = range.Match("");
            Assert.False(match.Succes());
        }

        [Fact]
        public void InputMultipleCharacters()
        {
            Range range = new Range('a', 'd');
            IMatch match = range.Match("dfd");
            Assert.True(match.Succes());
        }

        [Fact]
        public void InputCantStartWithCharacterNotWithinRange()
        {
            Range range = new Range('a', 'd');
            IMatch match = range.Match("edfsa");
            Assert.False(match.Succes());
        }

        [Fact]
        public void GetRemainingTextIfItMatches()
        {
            Range character = new Range('a', 'c');
            IMatch match = character.Match("abc");
            Assert.Equal("bc", match.RemainingText());
        }

        [Fact]
        public void GetTextIfItDoesntMatches()
        {
            Range character = new Range('a', 'c');
            IMatch match = character.Match("dab");
            Assert.Equal("dab", match.RemainingText());
        }
    }
}
