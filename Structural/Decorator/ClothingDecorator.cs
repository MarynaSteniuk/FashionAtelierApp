using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Decorator
{
    public abstract class ClothingDecorator : IClothing
    {
        protected IClothing _clothing;
        public ClothingDecorator(IClothing clothing)
        {
            _clothing = clothing;
        }
        public virtual string GetDescription()
        {
            return _clothing.GetDescription();
        }
        public virtual double GetPrice()
        {
            return _clothing.GetPrice();
        }
    }
}
