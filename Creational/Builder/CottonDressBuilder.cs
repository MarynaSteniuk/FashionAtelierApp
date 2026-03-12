using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.Builder
{
    public class CottonDressBuilder : IDressBuilder
    {
        private CustomDress _dress = new CustomDress();
        public void SetFabric() => _dress.Fabric = "Бавовна";
        public CustomDress GetResult() => _dress;
    }
}
