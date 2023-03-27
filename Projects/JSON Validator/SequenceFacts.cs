using System;
using Xunit;

namespace JSONValidator
{
    public class SequenceFacts
    {
        [Fact]
        public void ReturnFalseIfMatchedWithNullAndReturnsNullAsRemainingText()
        {
            Sequence ab = new Sequence(new Character('a'), new Character('b'));
            IMatch match = ab.Match(null);
            Assert.False(match.Succes());
        }

        [Fact]
        public void ReturnTrueForMultipleCharacterSequence()
        {
            Sequence ab = new Sequence(new Character('a'), new Character('b'));
            IMatch match = ab.Match("abc");
            Assert.True(match.Succes());
        }

        [Fact]
        public void ReturnRemainingTextForMultipleCharacterSequence()
        {
            Sequence ab = new Sequence(new Character('a'), new Character('b'));
            IMatch match = ab.Match("abcd");
            Assert.Equal("cd", match.RemainingText());
        }

        [Fact]
        public void ReturnProperMatchObjectWhenUsingSequenceAsASequenceParameter()
        {
            Sequence ab = new Sequence(new Character('a'), new Character('b'));
            Sequence abc = new Sequence(ab, new Character('c'));
            IMatch match = abc.Match("abcde");
            IMatch matchFalse = abc.Match("dbcde");
            Assert.True(match.Succes());
            Assert.False(matchFalse.Succes());
            Assert.Equal("de", match.RemainingText());
        }

        [Fact]
        public void ReturnPropermatchObjectUsingComplexSequence()
        {
            Choice hexDigits = new Choice(new Range('0', '9'), new Range('a', 'z'), new Range('A', 'Z'));
            Sequence hexSequence = new Sequence(new Character('u'), new Sequence(hexDigits, hexDigits, hexDigits, hexDigits));
            IMatch match = hexSequence.Match("u12Adrest");
            Assert.True(match.Succes());
            Assert.Equal("rest", match.RemainingText());
        }

        [Fact]
        public void TextDoesntChangeIfMachIsUnsuccesful()
        {
            Sequence ab = new Sequence(new Character('a'), new Character('b'));
            IMatch match = ab.Match("acbd");
            Assert.Equal("acbd", match.RemainingText());
        }
    }
}
