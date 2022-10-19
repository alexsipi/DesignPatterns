using System;
using System.Collections.Generic;
using System.Text;

namespace TestAPI.Logic
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime GetNow() {
            return DateTime.Now;
        }
    }
}
