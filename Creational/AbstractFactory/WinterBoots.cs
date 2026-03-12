using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.AbstractFactory
{
    public class WinterBoots : IShoes
    {
        public string GetDetails() => "Шкіряні зимові чоботи";
    }
}
