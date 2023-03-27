using System;
using Xunit;

namespace JSONValidator
{
    public class OptionalFacts
    {
        [Fact]
        public void ObjectPatternCanMatchWithNull()
        {
            Optional optional = new Optional(new Character('a'));
            IMatch match = optional.Match(null);
            Assert.True(match.Succes());
        }

        [Fact]
        public void ObjectPatternCanMatchWithEmptyString()
        {
            Optional optional = new Optional(new Character('a'));
            IMatch match = optional.Match("");
            Assert.True(match.Succes());
        }

        [Fact]
        public void ObjectPatternCanMatchWithTextThatStartsWithPattern()
        {
            Optional optional = new Optional(new Character('a'));
            IMatch match = optional.Match("abc");
            Assert.True(match.Succes());
        }

        [Fact]
        public void ObjectPatternCanMatchWithTextThatDoesntStartWithPattern()
        {
            Optional optional = new Optional(new Character('a'));
            IMatch match = optional.Match("bc");
            Assert.True(match.Succes());
        }

        [Fact]
        public void ReturnsFullTextIfInputDoesntStartWithPattern()
        {
            Optional optional = new Optional(new Character('a'));
            IMatch match = optional.Match("bc");
            Assert.Equal("bc", match.RemainingText());
        }

        [Fact]
        public void ReturnsRemainingTextIfInputStartsWithPattern()
        {
            Optional optional = new Optional(new Character('a'));
            IMatch match = optional.Match("abc");
            Assert.Equal("bc", match.RemainingText());
        }

        [Fact]
        public void ReturnsRemainingTextIfInputStartsWithPatternOnlyOance()
        {
            Optional optional = new Optional(new Character('a'));
            IMatch match = optional.Match("aabc");
            Assert.Equal("abc", match.RemainingText());
        }
    }
}
