using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.Factory
{
    public class Belt : IAccessory
    {
        public string GetName() => "Шкіряний ремінь";
    }
}
