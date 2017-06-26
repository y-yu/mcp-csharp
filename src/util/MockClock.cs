using System;

namespace MinimalCakePatternExample
{
    public class MockClockImpl : IClock
    {
        private DateTime date;

        public MockClockImpl(DateTime n)
        {
            this.date = n;
        }

        public DateTime now()
        {
            return this.date;
        }
    }
}