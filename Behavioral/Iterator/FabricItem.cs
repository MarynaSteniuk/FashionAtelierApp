using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Iterator
{
    public class FabricItem
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public FabricItem(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public string GetInfo()
        {
            return $"Тканина: {Name}, Колір: {Color}";
        }
    }
}
