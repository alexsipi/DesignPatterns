using System;

namespace TestAPI.Logic
{
    public interface IDateTimeProvider
    {
        DateTime GetNow();
    }
}
