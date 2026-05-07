using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.DependencyInjectionLab
{
    public interface IFabricWarehouse
    {
        void TakeFabric();
    }
    public class FabricWarehouse : IFabricWarehouse
    {
        public void TakeFabric()
        {
            Console.WriteLine("Тканина взята зі складу.");
        }
    }
}
