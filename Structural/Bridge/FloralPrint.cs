using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Bridge
{
    public class FloralPrint : IPrint
    {
        public string Apply() => "Квітковий принт";
    }
}
