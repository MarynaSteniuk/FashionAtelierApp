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
        public List<string> Inventory { get; private set; }
        private FabricWarehouse()
        {
            Inventory = new List<string>();
        }

        public static FabricWarehouse GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FabricWarehouse();
            }
            return _instance;
        }

        public void AddFabric(string fabric)
        {
            Inventory.Add(fabric);
        }
        public void ShowStatus()
        {
            System.Console.WriteLine($"Склад працює. Тканин в наявності: {Inventory.Count} шт.");
            foreach (var item in Inventory)
            {
                System.Console.WriteLine($" - {item}");
            }
        }
    }
}
