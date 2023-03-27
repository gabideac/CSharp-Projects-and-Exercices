using System;
using Xunit;

namespace JSONValidator
{
    public class ListFacts
    {
        [Fact]
        public void FindsOneList()
        {
            List list = new List(new Range('0', '9'), new Character(','));
            IMatch match = list.Match("1,2abc");
            Assert.Equal("abc", match.RemainingText());
        }

        [Fact]
        public void FindsListContainingMultipleSeparators()
        {
            List list = new List(new Range('0', '9'), new Character(','));
            IMatch match = list.Match("1,2,3,");
            Assert.Equal(",", match.RemainingText());
        }

        [Fact]
        public void FindsListWithOnlyOneElement()
        {
            List list = new List(new Range('0', '9'), new Character(','));
            IMatch match = list.Match("1abc");
            Assert.Equal("abc", match.RemainingText());
        }

        [Fact]
        public void ReturnsTrueIfListIsNotFound()
        {
            List list = new List(new Range('0', '9'), new Character(','));
            IMatch match = list.Match("abc");
            Assert.True(match.Succes());
        }
    }
}
