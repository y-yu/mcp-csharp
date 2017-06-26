using System;

namespace MinimalCakePatternExample
{
    public class Program
    {
        public static void Main()
        {
            RandomGeneratorService service = new RandomGeratorServiceImpl();

            Console.WriteLine(service.generate(20).ToString());
            Console.WriteLine(service.generate(20).ToString());
            Console.WriteLine(service.generate(20).ToString());
        }
    }
}