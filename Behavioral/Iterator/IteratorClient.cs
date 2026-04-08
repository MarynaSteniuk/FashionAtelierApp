using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Iterator
{
    public class IteratorClient
    {
        public void RunIterator()
        {
            System.Console.WriteLine("--- ТЕСТ: ІТЕРАТОР ---");
            FabricCatalog catalog = new FabricCatalog();
            catalog.AddFabric(new FabricItem("Шовк", "Червоний"));
            catalog.AddFabric(new FabricItem("Бавовна", "Білий"));
            catalog.AddFabric(new FabricItem("Вовна", "Чорний"));
            catalog.AddFabric(new FabricItem("Оксамит", "Смарагдовий"));
            IFabricIterator iterator = catalog.CreateIterator();
            System.Console.WriteLine("Клієнт гортає каталог тканин:");
            while (iterator.HasNext())
            {
                FabricItem item = iterator.Next();
                System.Console.WriteLine($" 📖 {item.GetInfo()}");
            }
        }
    }
}
