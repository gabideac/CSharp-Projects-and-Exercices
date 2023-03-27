using System;

namespace JSONValidator
{
    class List : IPattern
    {
        private readonly IPattern pattern;

        public List(IPattern element, IPattern separator)
        {
            Sequence sequence = new Sequence(separator, element);
            pattern = new Optional(new Sequence(element, new Many(sequence)));
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
