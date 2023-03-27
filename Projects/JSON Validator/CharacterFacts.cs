using System;
using Xunit;

namespace JSONValidator
{
    public class CharacterFacts
    {
        [Fact]
        public void SingleCharacterIsWithinRange()
        {
            Character character = new Character('a');
            IMatch match = character.Match("a");
            Assert.True(match.Succes());
        }

        [Fact]
        public void InputCantBeNull()
        {
            Character character = new Character('a');
            IMatch match = character.Match(null);
            Assert.False(match.Succes());
        }

        [Fact]
        public void InputCantBeEmpty()
        {
            Character character = new Character('a');
            IMatch match = character.Match("");
            Assert.False(match.Succes());
        }

        [Fact]
        public void InputMustMatchPattern()
        {
            Character character = new Character('a');
            IMatch match = character.Match("x");
            Assert.False(match.Succes());
        }

        [Fact]
        public void GetRemainingTextIfItMatches()
        {
            Character character = new Character('0');
            IMatch match = character.Match("02321");
            Assert.Equal("2321", match.RemainingText());
        }

        [Fact]
        public void GetTextIfItDoesntMatches()
        {
            Character character = new Character('a');
            IMatch match = character.Match("02321");
            Assert.Equal("02321", match.RemainingText());
        }
    }
}
