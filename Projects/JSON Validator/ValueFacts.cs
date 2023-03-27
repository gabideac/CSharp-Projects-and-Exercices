using System.Text;
using Xunit;

namespace JSONValidator
{
    public class ValueFacts
    {
        [Fact]
        public void MatchesWithNull()
        {
            var value = new Value();
            IMatch match = value.Match("null");
            Assert.True(match.Succes());
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void MatchesWithTrue()
        {
            var value = new Value();
            IMatch match = value.Match("true");
            Assert.True(match.Succes());
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void MatchesWithFalse()
        {
            var value = new Value();
            IMatch match = value.Match("false");
            Assert.True(match.Succes());
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void MatchesWithANumber()
        {
            var value = new Value();
            IMatch match = value.Match("250");
            Assert.True(match.Succes());
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void MatchesWithAString()
        {
            var value = new Value();
            IMatch match = value.Match("\"123abc\"");
            Assert.True(match.Succes());
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void MatchesWithAnArray()
        {
            var value = new Value();
            IMatch match = value.Match("[1, 2, 3, 4]");
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void MatchesWithAnArrayContainingOnlyWhitespace()
        {
            var value = new Value();
            IMatch match = value.Match("[ ]");
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void MatchesWithAnObject()
        {
            var value = new Value();
            IMatch match = value.Match("{\"one\" : 1, \"two\" : 2, \"three\" : 3}");
            Assert.Equal("", match.RemainingText());
        }
    }
}
