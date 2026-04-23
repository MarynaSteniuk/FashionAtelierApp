using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FashionAtelierApp.FunctionalPatterns.Decorator
{
    public class DecoratorTest
    {
        public static void Run()
        {
            Func<double, double> addCrystals = p => p + 800.0;
            Func<double, double> addLace = p => p + 300.0;
            Func<double, double> applyVipDiscount = p => p * 0.9;
            var calculator = new PriceCalculator(addCrystals, addLace, applyVipDiscount);
            double basePrice = 1000.0;
            double finalPrice = calculator.Calculate(basePrice);
            Console.WriteLine($"\nФункціональний Декоратор. База: {basePrice}, Фінал: {finalPrice}");
        }
    }
}
