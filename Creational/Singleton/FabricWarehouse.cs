using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.Singleton
{
    public class FabricWarehouse
    {
        private static FabricWarehouse _instance;
        private FabricWarehouse() { }

        public static FabricWarehouse GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FabricWarehouse();
            }
            return _instance;
        }

        public void ShowStatus() => System.Console.WriteLine("Склад працює.");
    }
}
