﻿using System;

namespace JSONValidator
{
    class Text : IPattern
    {
        readonly string prefix;

        public Text(string prefix)
        {
            this.prefix = prefix;
        }

        public IMatch Match(string text)
        {
            return string.IsNullOrEmpty(text) || !text.StartsWith(prefix) ? new Match(text, false) : new Match(text[prefix.Length..], true);
        }
    }
}
