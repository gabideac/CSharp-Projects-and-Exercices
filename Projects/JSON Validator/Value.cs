using System;

namespace JSONValidator
{
    public class Value : IPattern
    {
        private readonly IPattern pattern;

        public Value()
        {
            var value = new Choice(new JsonString(), new Number(), new Text("null"), new Text("true"), new Text("false"));
            var ws = new Many(new Any(" \n\r\t"));
            var element = new Sequence(ws, value, ws);
            var member = new Sequence(ws, new JsonString(), ws, new Character(':'), element);
            var array = new Sequence(new Character('['), ws, new List(element, new Character(',')), new Character(']'));
            var jsonObject = new Sequence(new Character('{'), ws, new List(member, new Character(',')), new Character('}'));
            value.Add(array);
            value.Add(jsonObject);
            pattern = element;
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
