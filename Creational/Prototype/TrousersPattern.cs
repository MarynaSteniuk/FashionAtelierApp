using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.Prototype
{
    public class TrousersPattern : IClothingPattern
    {
        public string Style { get; set; }
        public TrousersPattern(string style) { Style = style; }

        public IClothingPattern Clone() => new TrousersPattern(this.Style);
    }
}
