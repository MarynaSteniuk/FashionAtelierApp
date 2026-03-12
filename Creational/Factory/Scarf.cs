using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.Factory
{
    public class Scarf : IAccessory
    {
        public string GetName() => "Шовковий шарф";
    }
}
