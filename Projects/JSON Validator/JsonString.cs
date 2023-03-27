using System;

namespace JSONValidator
{
    public class JsonString : IPattern
    {
        private readonly IPattern pattern;

        public JsonString()
        {
            var hex = new Choice(new Range('0', '9'), new Range('a', 'f'), new Range('A', 'F'));
            var unicodeCharacters = new Sequence(new Character('u'), hex, hex, hex, hex);
            var escape = new Choice(unicodeCharacters, new Any("/bfnrt\\\""));
            var character = new Choice(new Range(' ', '!'), new Range('#', '['), new Range(']', char.MaxValue));
            var characters = new Many(new Choice(character, new Sequence(new Character('\\'), escape)));
            pattern = new Sequence(new Character('\"'), characters, new Character('\"'));
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
