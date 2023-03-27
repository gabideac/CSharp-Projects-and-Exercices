using System;
using Xunit;

namespace JSONValidator
{
    public class ManyFacts
    {
        [Fact]
        public void CanBeNullOrEmptyString()
        {
            Many many = new Many(new Character('a'));
            IMatch matchNull = many.Match(null);
            IMatch matchEmpty = many.Match("");
            Assert.Null(matchNull.RemainingText());
            Assert.Equal("", matchEmpty.RemainingText());
        }

        [Fact]
        public void ReturnsRemnainingTextWithOneInstanceOfCharacterFound()
        {
            Many many = new Many(new Character('a'));
            IMatch match = many.Match("abc");
            Assert.Equal("bc", match.RemainingText());
        }

        [Fact]
        public void ReturnsRemainingTextWhenFoundingMultipleInstancesOfCharacter()
        {
            Many many = new Many(new Character('a'));
            IMatch match = many.Match("aaaaaabc");
            Assert.Equal("bc", match.RemainingText());
        }

        [Fact]
        public void ReturnCompleteTextAndTrueIfApatternIsNotFound()
        {
            Many many = new Many(new Character('a'));
            IMatch match = many.Match("bc");
            Assert.Equal("bc", match.RemainingText());
            Assert.True(match.Succes());
        }

        [Fact]
        public void ReturnRemainingTextWhenUsingRangePattern()
        {
            Many many = new Many(new Range('0', '9'));
            IMatch match = many.Match("753bc");
            Assert.Equal("bc", match.RemainingText());
            Assert.True(match.Succes());
        }

        [Fact]
        public void KeepsNonBegginingPatternValidCharactersInRemainingText()
        {
            Many many = new Many(new Range('0', '9'));
            IMatch match = many.Match("123abc123");
            Assert.Equal("abc123", match.RemainingText());
            Assert.True(match.Succes());
        }
    }
}
