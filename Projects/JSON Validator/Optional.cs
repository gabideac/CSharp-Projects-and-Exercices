using System;

namespace JSONValidator
{
    class Optional : IPattern
    {
        readonly IPattern pattern;

        public Optional(IPattern pattern)
        {
            this.pattern = pattern;
        }

        public IMatch Match(string text)
        {
            IMatch match = pattern.Match(text);
            return new Match(match.RemainingText(), true);
        }
    }
}
