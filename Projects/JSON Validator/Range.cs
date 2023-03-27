using System;

namespace JSONValidator
{
    public class Range : IPattern
    {
        readonly char start;
        readonly char end;

        public Range(char start, char end)
        {
            this.start = start;
            this.end = end;
        }

        public IMatch Match(string text)
        {
            bool succes = !string.IsNullOrEmpty(text) && text[0] >= start && text[0] <= end;
            if (succes)
            {
                text = text[1..];
            }

            return new Match(text, succes);
        }
    }
}
