using System;

namespace MinimalCakePatternExample
{
    public interface IClock
    {
        DateTime now();
    }

    public interface IUsesClock
    {
        IClock clock { get; }
    }
}