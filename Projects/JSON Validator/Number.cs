using System;

namespace JSONValidator
{
    public class Number : IPattern
    {
        private readonly IPattern pattern;

        public Number()
        {
            var zero = new Character('0');
            var negative = new Optional(new Character('-'));
            var digit = new Range('0', '9');
            var digits = new OneOrMore(digit);
            var sign = new Optional(new Any("+-"));
            var integer = new Sequence(negative, new Choice(zero, digits));
            var fraction = new Optional(new Sequence(new Character('.'), digits));
            var exponent = new Optional(new Sequence(new Any("eE"), sign, digits));
            pattern = new Sequence(integer, fraction, exponent);
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
