using System;
using Xunit;

namespace JSONValidator
{
    public class TextFacts
    {
        [Fact]
        public void InputCantBeNull()
        {
            Text text = new Text("ab");
            IMatch match = text.Match(null);
            Assert.False(match.Succes());
        }

        [Fact]
        public void InputCantBeEmpty()
        {
            Text text = new Text("Ee");
            IMatch match = text.Match("");
            Assert.False(match.Succes());
        }

        [Fact]
        public void ReturnsTrueIfValid()
        {
            Text text = new Text("Este");
            IMatch match = text.Match("Este frig");
            Assert.True(match.Succes());
        }

        [Fact]
        public void ReturnsRemainingTextIfValid()
        {
            Text text = new Text("Este");
            IMatch match = text.Match("Este frig");
            Assert.Equal(" frig", match.RemainingText());
        }

        [Fact]
        public void ReturnsFalseIfTextLengthIsSmallerThatPrefixLength()
        {
            Text text = new Text("Iarna");
            IMatch match = text.Match("Iar");
            Assert.False(match.Succes());
        }

        [Fact]
        public void ReturnsCompleteTextIfUnsuccesfull()
        {
            Text text = new Text("text");
            IMatch match = text.Match("not");
            Assert.Equal("not", match.RemainingText());
        }

        [Fact]
        public void ReturnsRemainingTextAndTrueIfTextIsEmptyString()
        {
            Text text = new Text("");
            IMatch match = text.Match("not");
            Assert.Equal("not", match.RemainingText());
            Assert.True(match.Succes());
        }
    }
}
