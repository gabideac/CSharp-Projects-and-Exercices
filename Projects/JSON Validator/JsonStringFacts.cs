using System;
using Xunit;

namespace JSONValidator
{
    public class JsonStringFacts
    {
        public static string Quoted(string text)
           => $"\"{text}\"";

        [Fact]
        public void MustBeWrappedInDubleQuotes()
        {
            var jsonString = new JsonString();
            IMatch match = jsonString.Match(Quoted(" "));
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void CanBeEmptyQuotedString()
        {
            var jsonString = new JsonString();
            IMatch match = jsonString.Match(Quoted(""));
            Assert.True(match.Succes());
        }

        [Fact]
        public void MatchesWithMultipleCharacters()
        {
            var jsonString = new JsonString();
            IMatch match = jsonString.Match(Quoted("123abc"));
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void MatchesWithLargeUnicodeCharacters()
        {
            var jsonString = new JsonString();
            IMatch match = jsonString.Match(Quoted("⛅⚾"));
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void MatchesWithEscapedQuotationMark()
        {
            var jsonString = new JsonString();
            IMatch match = jsonString.Match(Quoted(@"\""a\"" b"));
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void MatchesWithEscapedReverseSolidus()
        {
            var jsonString = new JsonString();
            IMatch match = jsonString.Match(Quoted(@"a \\ b"));
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void MatchesWithEscapedSolidus()
        {
            var jsonString = new JsonString();
            IMatch match = jsonString.Match(Quoted(@"a \/ b"));
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void MatchesWithEscapedUnicodeCharacters()
        {
            var jsonString = new JsonString();
            IMatch match = jsonString.Match(Quoted(@"a \u26Be b"));
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void MatchesWithRemainingControlCharacters()
        {
            var jsonString = new JsonString();
            IMatch match = jsonString.Match(Quoted(@"a \b \f \n \r \t b"));
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void MatchesWithStringThatEndsWithControlCharacter()
        {
            var jsonString = new JsonString();
            IMatch match = jsonString.Match(Quoted(@"\u123a a \u123a"));
            Assert.Equal("", match.RemainingText());
        }
    }
}
