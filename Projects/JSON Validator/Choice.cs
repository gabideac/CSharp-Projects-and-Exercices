using System;

namespace JSONValidator
{
    class Choice : IPattern
    {
        private IPattern[] patterns;

        public Choice(params IPattern[] patterns)
        {
            this.patterns = patterns;
        }

        public IMatch Match(string text)
        {
            IMatch match;
            foreach (var pattern in patterns)
            {
                match = pattern.Match(text);
                if (match.Succes())
                {
                    return new Match(match.RemainingText(), true);
                }
            }

            return new Match(text, false);
        }

        public void Add(IPattern newPattern)
        {
            Array.Resize(ref patterns, patterns.Length + 1);
            patterns[patterns.Length - 1] = newPattern;
        }
    }
}
