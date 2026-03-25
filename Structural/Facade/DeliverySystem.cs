using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Facade
{
    public class DeliverySystem
    {
        public void Dispatch()
        {
            System.Console.WriteLine(" Доставка: Замовлення передано кур'єру. Прямує до клієнта!");
        }
    }
}
