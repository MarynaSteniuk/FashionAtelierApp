using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Proxy
{
    public class VIPCollection : ICollectionAccess
    {
        public VIPCollection()
        {
            System.Console.WriteLine(" Завантаження 3D-моделей VIP-колекції...");
        }

        public string ViewCollection()
        {
            return "Показ секретної VIP-колекції 'Осінь-Зима' відкрито!";
        }
    }
}
