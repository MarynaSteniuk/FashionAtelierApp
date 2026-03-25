using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Bridge
{
    public class WinterCoat : Garment
    {
        public WinterCoat(IPrint print) : base(print) { }
        public override string Manufacture()
        {
            return $"Зимове пальто. Дизайн: {_print.Apply()}";
        }
    }
}
