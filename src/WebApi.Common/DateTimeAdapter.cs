using System;

namespace WebApi.Common
{
    public class DateTimeAdapter : IDateTime
    {
        public DateTime UtcTime
        {
            get { return DateTime.UtcNow; }
        }
    }
}
