using System;

namespace JSONValidator
{
    class Any : IPattern
    {
        readonly string accepted;

        public Any(string accepted)
        {
            this.accepted = accepted;
        }

        public IMatch Match(string text)
        {
            bool succes = !string.IsNullOrEmpty(text) && accepted.Contains(text[0]);
            if (succes)
            {
                text = text[1..];
            }

            return new Match(text, succes);
        }
    }
}
