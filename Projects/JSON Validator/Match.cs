using System;

namespace JSONValidator
{
    public class Match : IMatch
    {
        readonly bool succes;
        readonly string remainingText;

        public Match(string text, bool succes)
        {
            this.remainingText = text;
            this.succes = succes;
        }

        public string RemainingText()
        {
            return remainingText;
        }

        public bool Succes()
        {
            return succes;
        }
    }
}
