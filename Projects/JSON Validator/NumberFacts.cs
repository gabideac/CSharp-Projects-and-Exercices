using System;
using Xunit;

namespace JSONValidator
{
    public class NumberFacts
    {
        [Fact]
        public void CanMatchWithZero()
        {
            Number number = new Number();
            IMatch match = number.Match("0");
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void CanMatchWithASingleDigit()
        {
            Number number = new Number();
            IMatch match = number.Match("5");
            Assert.True(match.Succes());
        }

        [Fact]
        public void CanMatchWithMultipleDigitNumberCheckingEveryDigit()
        {
            Number number = new Number();
            IMatch match = number.Match("50");
            Assert.True(match.Succes());
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void CantMatchWithNullOrWithEmptyString()
        {
            Number number = new Number();
            IMatch matchNull = number.Match(null);
            Assert.False(matchNull.Succes());
            IMatch matchEmpty = number.Match("");
            Assert.False(matchEmpty.Succes());
        }

        [Fact]
        public void DoesntValidateCompleteNumberIfItStartsWithZero()
        {
            Number number = new Number();
            IMatch match = number.Match("05");
            Assert.Equal("5", match.RemainingText());
        }

        [Fact]
        public void CanMatchWithANegativeNumber()
        {
            Number number = new Number();
            IMatch match = number.Match("-5");
            Assert.True(match.Succes());
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void CanMatchWithFractionalNumbers()
        {
            Number number = new Number();
            IMatch match = number.Match("1.1");
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void FractionDotShouldHaveDigitsAfterIt()
        {
            Number number = new Number();
            IMatch match = number.Match("10.");
            Assert.Equal(".", match.RemainingText());
        }

        [Fact]
        public void CanMatchWithNumbersWithExponent()
        {
            Number number = new Number();
            IMatch matche = number.Match("10e2");
            IMatch matchE = number.Match("10E2");
            Assert.Equal("", matche.RemainingText());
            Assert.Equal("", matchE.RemainingText());
        }

        [Fact]
        public void ExponentCanHavePositiveOrNegative()
        {
            Number number = new Number();
            IMatch matchPositive = number.Match("10e+3");
            IMatch matchNegative = number.Match("10E-3");
            Assert.Equal("", matchPositive.RemainingText());
            Assert.Equal("", matchNegative.RemainingText());
        }

        [Fact]
        public void TheExponentMustBeComplete()
        {
            Number number = new Number();
            IMatch match = number.Match("10e");
            Assert.Equal("e", match.RemainingText());
            IMatch matchPositive = number.Match("10E+");
            Assert.Equal("E+", matchPositive.RemainingText());
            IMatch matchNegative = number.Match("10e-");
            Assert.Equal("e-", matchNegative.RemainingText());
        }
    }
}
