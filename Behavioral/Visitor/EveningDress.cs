using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Visitor
{
    public class EveningDress : IGarmentElement
    {
        public double Price { get; } = 5000.0; 
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
