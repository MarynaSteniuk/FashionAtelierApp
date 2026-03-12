using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.Builder
{
    public class SilkDressBuilder : IDressBuilder
    {
        private CustomDress _dress = new CustomDress();
        public void SetFabric() => _dress.Fabric = "Шовк";
        public CustomDress GetResult() => _dress;
    }
}
