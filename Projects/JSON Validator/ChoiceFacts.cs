using System;
using Xunit;

namespace JSONValidator
{
    public class ChoiceFacts
    {
        [Fact]
        public void InputCantBeNull()
        {
            var digits = new Choice(new Range('1', '9'), new Character('0'));
            IMatch match = digits.Match(null);
            Assert.False(match.Succes());
        }

        [Fact]
        public void InputCantBeEmpty()
        {
            var digits = new Choice(new Range('1', '9'), new Character('0'));
            IMatch match = digits.Match("");
            Assert.False(match.Succes());
        }

        [Fact]
        public void CantStartWithLetterGivenParametersThatAllowsOnlyDigits()
        {
            var digits = new Choice(new Range('1', '9'), new Character('0'));
            IMatch match = digits.Match("a02");
            Assert.False(match.Succes());
        }

        [Fact]
        public void CanStartWithZeroGivenParametersThatAllowsOnlyDigits()
        {
            var digits = new Choice(new Character('0'), new Range('1', '9'));
            IMatch match = digits.Match("02");
            Assert.True(match.Succes());
        }

        [Fact]
        public void GetRemainingTextIfItMatches()
        {
            var digits = new Choice(new Character('0'), new Range('1', '9'));
            IMatch match = digits.Match("02321");
            Assert.Equal("2321", match.RemainingText());
        }

        [Fact]
        public void GetTextIfItDoesntMatches()
        {
            var digits = new Choice(new Range('1', '9'));
            IMatch match = digits.Match("02321");
            Assert.Equal("02321", match.RemainingText());
        }

        [Fact]
        public void CanHaveTwoChoicesAsParameters()
        {
            var digits = new Choice(new Character('0'), new Range('1', '9'));
            var hex = new Choice(new Range('a', 'f'), new Range('A', 'F'));
            var choice = new Choice(digits, hex);
            IMatch matchTrue = choice.Match("c4");
            IMatch matchTrueTwo = choice.Match("C4");
            IMatch matchFalse = choice.Match("i4");
            Assert.True(matchTrue.Succes());
            Assert.True(matchTrueTwo.Succes());
            Assert.False(matchFalse.Succes());
        }

        [Fact]
        public void CanAddPatternToChoice()
        {
            var choice = new Choice(new Range('A', 'Z'), new Range('a', 'z'));
            choice.Add(new Range('0', '9'));
            IMatch match = choice.Match("5Aa");
            Assert.Equal("Aa", match.RemainingText());
        }
    }
}
