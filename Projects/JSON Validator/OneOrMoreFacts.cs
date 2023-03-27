using System;
using Xunit;

namespace JSONValidator
{
    public class OneOrMoreFacts
    {
        [Fact]
        public void ReturnsTrueAtLeastOneInstanceOfPatternIsFound()
        {
            OneOrMore oneOrMore = new OneOrMore(new Character('1'));
            IMatch match = oneOrMore.Match("123");
            Assert.True(match.Succes());
        }

        [Fact]
        public void UsesAllInstancesOfPattern()
        {
            OneOrMore oneOrMore = new OneOrMore(new Range('1', '9'));
            IMatch match = oneOrMore.Match("123a");
            Assert.Equal("a", match.RemainingText());
        }

        [Fact]
        public void ReturnsFalseIfPatternIsNotFoundAtLeastOance()
        {
            OneOrMore oneOrMore = new OneOrMore(new Range('1', '9'));
            IMatch match = oneOrMore.Match("abc");
            Assert.False(match.Succes());
        }
    }
}
