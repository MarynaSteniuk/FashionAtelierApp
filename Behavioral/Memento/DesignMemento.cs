using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Memento
{
    public class DesignMemento
    {
        public string Color { get; private set; }
        public string Fabric { get; private set; }
        public string Style { get; private set; }

        public DesignMemento(string color, string fabric, string style)
        {
            Color = color;
            Fabric = fabric;
            Style = style;
        }
    }
}
