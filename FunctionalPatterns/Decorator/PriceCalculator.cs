using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FashionAtelierApp.FunctionalPatterns.Decorator
{
    public class PriceCalculator
    {
        private Func<double, double> _calculateFinalPrice;
        public PriceCalculator(params Func<double, double>[] modifiers)
        {
            _calculateFinalPrice = price => price;
            foreach (var modifier in modifiers)
            {
                var previousFunction = _calculateFinalPrice;
                _calculateFinalPrice = price => modifier(previousFunction(price));
            }
        }
        public double Calculate(double basePrice)
        {
            return _calculateFinalPrice(basePrice);
        }
    }
}