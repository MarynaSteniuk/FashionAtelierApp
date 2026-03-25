using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Bridge
{
    public class EveningDress : Garment
    {
        public EveningDress(IPrint print) : base(print) { }
        public override string Manufacture()
        {
            return $"Вечірня сукня. Дизайн: {_print.Apply()}";
        }
    }
}
