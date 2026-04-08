using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Visitor
{
    public class DiscountVisitor : IVisitor
    {
        public void Visit(EveningDress dress)
        {
            double finalPrice = dress.Price * 0.80; 
            System.Console.WriteLine($" Знижка: Вечірня сукня зі знижкою 20% коштуватиме {finalPrice} грн.");
        }
        public void Visit(BusinessSuit suit)
        {
            double finalPrice = suit.Price * 0.90; 
            System.Console.WriteLine($" Знижка: Діловий костюм зі знижкою 10% коштуватиме {finalPrice} грн.");
        }
    }
}
