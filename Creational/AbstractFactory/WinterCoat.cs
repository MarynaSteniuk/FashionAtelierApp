using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.AbstractFactory
{
    public class WinterCoat : IClothing
    {
        public string GetDetails() => "Тепле зимове пальто";
    }
}
