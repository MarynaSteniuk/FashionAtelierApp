using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.Prototype
{
    public class DressPattern : IClothingPattern
    {
        public string Size { get; set; }
        public DressPattern(string size) { Size = size; }

        public IClothingPattern Clone() => new DressPattern(this.Size);
    }
}
