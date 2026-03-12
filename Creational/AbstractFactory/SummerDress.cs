using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.AbstractFactory
{
    public class SummerDress : IClothing
    {
        public string GetDetails() => "Легка сукня";
    }
}
