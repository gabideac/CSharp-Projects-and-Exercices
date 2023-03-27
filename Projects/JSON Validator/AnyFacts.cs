using System;
using Xunit;

namespace JSONValidator
{
    public class AnyFacts
    {
        [Fact]
        public void InputCantBeNull()
        {
            Any any = new Any("Ee");
            IMatch match = any.Match(null);
            Assert.False(match.Succes());
        }

        [Fact]
        public void InputCantBeEmpty()
        {
            Any any = new Any("Ee");
            IMatch match = any.Match("");
            Assert.False(match.Succes());
        }

        [Fact]
        public void ReturnsTrueIfValid()
        {
            Any any = new Any("Ee");
            IMatch match = any.Match("este");
            Assert.True(match.Succes());
        }

        [Fact]
        public void ReturnsRemainingTextIfValid()
        {
            Any any = new Any("Ee");
            IMatch match = any.Match("Este");
            Assert.Equal("ste", match.RemainingText());
        }
    }
}
