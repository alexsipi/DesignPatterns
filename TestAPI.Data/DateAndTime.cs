using System;

namespace TestAPI.Logic
{
    public class DateAndTime : IDateAndTime
    {
        IDateTimeProvider myDateTime;
        public DateAndTime(IDateTimeProvider dateTimeProvider) {
            myDateTime = dateTimeProvider;
        }

        public DateTime GetTime() {
            return myDateTime.GetNow();
        }
    }
}
