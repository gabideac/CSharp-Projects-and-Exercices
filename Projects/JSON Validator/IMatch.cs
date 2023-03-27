using System;

namespace JSONValidator
{
    public interface IMatch
    {
        bool Succes();

        string RemainingText();
    }
}
