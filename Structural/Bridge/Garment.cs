using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Bridge
{
    public abstract class Garment
    {
        protected IPrint _print; 
        public Garment(IPrint print)
        {
            _print = print;
        }
        public abstract string Manufacture();
    }
}
