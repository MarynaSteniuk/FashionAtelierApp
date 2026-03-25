using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Bridge
{
    public class CheckeredPrint : IPrint
    {
        public string Apply() => "У клітинку";
    }
}
