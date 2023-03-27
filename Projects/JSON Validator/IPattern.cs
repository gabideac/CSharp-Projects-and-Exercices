using System;

namespace JSONValidator
{
    public interface IPattern
    {
        IMatch Match(string text);
    }
}
