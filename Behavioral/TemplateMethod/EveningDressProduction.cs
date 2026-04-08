using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.TemplateMethod
{
    public class EveningDressProduction : GarmentProductionTemplate
    {
        protected override void CutFabric()
        {
            System.Console.WriteLine(" Обережний розкрій делікатного шовку.");
        }
        protected override void SewGarment()
        {
            System.Console.WriteLine(" Пошиття сукні прихованими швами.");
        }
        protected override void AddDecorations()
        {
            System.Console.WriteLine(" Пришивання бісеру, стразів та мережива вручну.");
        }
    }
}
