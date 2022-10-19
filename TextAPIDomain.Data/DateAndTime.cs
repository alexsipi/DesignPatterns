using System;

namespace TextAPIDomain.Data
{
    public class DateAndTime
    {
        private DateTime date;

        public DateAndTime GetDateAndTime(DateAndTime) {

            this.date = DateTime.Now;
            return date;
        }
    }
}
