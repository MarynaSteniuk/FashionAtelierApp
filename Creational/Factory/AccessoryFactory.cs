using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.Factory
{
    public class AccessoryFactory
    {
        public IAccessory CreateAccessory(string type)
        {
            if (type == "bag") return new Handbag();
            else if (type == "belt") return new Belt();
            else if (type == "scarf") return new Scarf();
            return null;
        }
    }
}
