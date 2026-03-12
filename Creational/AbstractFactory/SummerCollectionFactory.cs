using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.AbstractFactory
{
    public class SummerCollectionFactory : ICollectionFactory
    {
        public IClothing CreateClothing() => new SummerDress();
        public IShoes CreateShoes() => new SummerSandals();
    }
}
