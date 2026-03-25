using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Decorator
{
    public class SilkRibbonDecorator : ClothingDecorator
    {
        public SilkRibbonDecorator(IClothing clothing) : base(clothing) { }
        public override string GetDescription()
        {
            return base.GetDescription() + " + Шовкова стрічка";
        }
        public override double GetPrice()
        {
            return base.GetPrice() + 150.0;
        }
    }
}
