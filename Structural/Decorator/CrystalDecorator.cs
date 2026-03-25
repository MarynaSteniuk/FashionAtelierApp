using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Decorator
{
    public class CrystalDecorator : ClothingDecorator
    {
        public CrystalDecorator(IClothing clothing) : base(clothing) { }
        public override string GetDescription()
        {
            return base.GetDescription() + " + Стрази Swarovski";
        }
        public override double GetPrice()
        {
            return base.GetPrice() + 800.0;
        }
    }
}
