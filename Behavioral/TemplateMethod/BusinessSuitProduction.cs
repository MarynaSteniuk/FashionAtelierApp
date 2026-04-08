using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.TemplateMethod
{
    public class BusinessSuitProduction : GarmentProductionTemplate
    {
        protected override void CutFabric()
        {
            System.Console.WriteLine(" Точний розкрій щільної вовни за строгими лекалами.");
        }
        protected override void SewGarment()
        {
            System.Console.WriteLine(" Пошиття піджака та штанів з міцною підкладкою.");
        }
    }
}
