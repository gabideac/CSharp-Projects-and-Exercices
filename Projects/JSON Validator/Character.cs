using System;

namespace JSONValidator
{
    public class Character : IPattern
    {
        readonly char pattern;

        public Character(char pattern)
        {
            this.pattern = pattern;
        }

        public IMatch Match(string text)
        {
            bool succes = !string.IsNullOrEmpty(text) && text[0] == pattern;
            if (succes)
            {
                text = text[1..];
            }

            return new Match(text, succes);
        }
    }
}
