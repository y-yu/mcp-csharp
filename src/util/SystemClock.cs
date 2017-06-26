using System;

namespace MinimalCakePatternExample
{
    public class SystemClockImpl : IClock
    {
        public DateTime now()
        {
            return System.DateTime.Now;
        }
    }
}