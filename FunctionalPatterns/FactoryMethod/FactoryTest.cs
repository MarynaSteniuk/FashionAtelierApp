using System;

namespace FashionAtelierApp.FunctionalPatterns.FactoryMethod
{
    public class FactoryTest
    {
        public static void Run()
        {
            var atelier = new FunctionalAtelier();
            var coat = atelier.CreateGarment("Coat");
            var dress = atelier.CreateGarment("Dress");
            Console.WriteLine($"\nСтворено функціонально: {coat.GetType().Name} та {dress.GetType().Name}");
        }
    }
}
