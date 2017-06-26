using System;

namespace MinimalCakePatternExample
{
    public class MockRandomGeratorServiceImpl
        : RandomGeneratorService
    {
        private IClock _clock;
        public override IClock clock { get { return _clock; } }

        public MockRandomGeratorServiceImpl(DateTime dt)
        {
            _clock = new MockClockImpl(dt);
        }
    }
}