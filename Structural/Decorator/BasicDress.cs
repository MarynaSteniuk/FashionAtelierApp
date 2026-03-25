using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Decorator
{
    public class BasicDress : IClothing
    {
        public string GetDescription()
        {
            return "Базова сукня";
        }
        public double GetPrice()
        {
            return 1000.0; 
        }
    }
}
