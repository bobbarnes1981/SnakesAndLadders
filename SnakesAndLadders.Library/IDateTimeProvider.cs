using System;

namespace SnakesAndLadders.Library
{
    public interface IDateTimeProvider
    {
        DateTime Now { get; }
    }
}
