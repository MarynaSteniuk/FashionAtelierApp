using FashionAtelierApp.Structural.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Visitor
{
    public interface IVisitor
    {
        void Visit(EveningDress dress);
        void Visit(BusinessSuit suit);
    }
}
