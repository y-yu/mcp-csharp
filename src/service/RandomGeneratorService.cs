namespace MinimalCakePatternExample
{
    public abstract class RandomGeneratorService : IUsesClock
    {
        // ここをコード生成かなんかで作れたらいいなあ……
        public abstract IClock clock { get; }

        public int generate(int max)
        {
            return clock.now().Millisecond % max;
        }
    }

    public class RandomGeratorServiceImpl 
        : RandomGeneratorService
    {
        private IClock _clock = new SystemClockImpl();
        public override IClock clock { get { return _clock; } }
    }
}