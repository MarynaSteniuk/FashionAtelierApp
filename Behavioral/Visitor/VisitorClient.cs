using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace FashionAtelierApp.Behavioral.Visitor
{
    public class VisitorClient
    {
        public void RunVisitor()
        {
            System.Console.WriteLine("--- ТЕСТ: ВІДВІДУВАЧ (VISITOR) ---");
            List<IGarmentElement> wardrobe = new List<IGarmentElement> {
                new EveningDress(),
                new BusinessSuit()
            };
            IVisitor discountCalculator = new DiscountVisitor();
            IVisitor labelPrinter = new CareLabelVisitor();
            System.Console.WriteLine("\n[Запуск алгоритму: Чорна П'ятниця]");
            foreach (var garment in wardrobe)
            {
                garment.Accept(discountCalculator);
            }
            System.Console.WriteLine("\n[Запуск алгоритму: Друк ярликів]");
            foreach (var garment in wardrobe)
            {
                garment.Accept(labelPrinter);
            }
        }
    }
}
