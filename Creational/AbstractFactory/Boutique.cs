using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.AbstractFactory
{
    public class Boutique
    {
        private IClothing _clothing;
        private IShoes _shoes;

        public Boutique(ICollectionFactory factory)
        {
            _clothing = factory.CreateClothing();
            _shoes = factory.CreateShoes();
        }

        public void ShowShowcase()
        {
            System.Console.WriteLine($"На вітрині: {_clothing.GetDetails()} та {_shoes.GetDetails()}");
        }
    }
}
