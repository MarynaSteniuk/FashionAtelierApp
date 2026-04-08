using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Visitor
{
    public class CareLabelVisitor : IVisitor
    {
        public void Visit(EveningDress dress)
        {
            System.Console.WriteLine(" Бірка (Сукня): Тільки делікатна хімчистка! Берегти від прасок.");
        }
        public void Visit(BusinessSuit suit)
        {
            System.Console.WriteLine(" Бірка (Костюм): Прасування з парою, машинне прання заборонено.");
        }
    }
}
