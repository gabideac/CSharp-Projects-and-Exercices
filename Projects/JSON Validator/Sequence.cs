using System;

namespace JSONValidator
{
    class Sequence : IPattern
    {
        readonly IPattern[] patterns;

        public Sequence(params IPattern[] patterns)
        {
            this.patterns = patterns;
        }

        public IMatch Match(string text)
        {
            IMatch match = new Match(text, true);
            foreach (IPattern pattern in patterns)
            {
                match = pattern.Match(match.RemainingText());
                if (!match.Succes())
                {
                    return new Match(text, false);
                }
            }

            return new Match(match.RemainingText(), true);
        }
    }
}
