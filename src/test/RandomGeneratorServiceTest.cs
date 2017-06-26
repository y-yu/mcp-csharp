using System;
using NUnit.Framework;

namespace MinimalCakePatternExample
{
    [TestFixture]
    public class RandomGeneratorServiceTests
    {
        public RandomGeneratorService sut;

        [SetUp]
        public void Init()
        {
            DateTime date = new DateTime(1968, 6, 7);
            sut = new MockRandomGeratorServiceImpl(date);
        }

        [Test]
        public void generate_should_return_a_0_if_the_clock_returns_0_milli_seconds()
        {
            Assert.AreEqual(sut.generate(100), 0);
        }
}
}