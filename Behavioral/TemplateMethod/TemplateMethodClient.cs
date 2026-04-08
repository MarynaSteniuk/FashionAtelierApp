using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.TemplateMethod
{
    public class TemplateMethodClient
    {
        public void RunTemplateMethod()
        {
            System.Console.WriteLine("--- ТЕСТ: ШАБЛОННИЙ МЕТОД (TEMPLATE METHOD) ---");
            System.Console.WriteLine("\n[Замовлення 1: Вечірня сукня]");
            GarmentProductionTemplate dress = new EveningDressProduction();
            dress.ManufactureGarment();
            System.Console.WriteLine("\n[Замовлення 2: Діловий костюм]");
            GarmentProductionTemplate suit = new BusinessSuitProduction();
            suit.ManufactureGarment();
        }
    }
}
