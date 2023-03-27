using System;

namespace JSONValidator
{
    class Many : IPattern
    {
        readonly IPattern pattern;

        public Many(IPattern pattern)
        {
            this.pattern = pattern;
        }

        public IMatch Match(string text)
        {
            IMatch match = pattern.Match(text);
            while (match.Succes())
            {
                match = pattern.Match(match.RemainingText());
            }

            return new Match(match.RemainingText(), true);
        }
    }
}
