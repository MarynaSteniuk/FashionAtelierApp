using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.AbstractFactory
{
    public class WinterCollectionFactory : ICollectionFactory
    {
        public IClothing CreateClothing() => new WinterCoat();
        public IShoes CreateShoes() => new WinterBoots();
    }
}
