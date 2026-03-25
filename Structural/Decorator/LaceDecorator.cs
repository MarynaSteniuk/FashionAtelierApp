using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Decorator
{
    public class LaceDecorator : ClothingDecorator
    {
        public LaceDecorator(IClothing clothing) : base(clothing) { }
        public override string GetDescription()
        {
            return base.GetDescription() + " + Мереживо";
        }
        public override double GetPrice()
        {
            return base.GetPrice() + 250.0;
        }
    }
}
