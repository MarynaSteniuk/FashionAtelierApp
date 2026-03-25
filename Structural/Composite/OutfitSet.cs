using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace FashionAtelierApp.Structural.Composite
{
    public class OutfitSet : IOutfitComponent
    {
        private string _setName;
        private List<IOutfitComponent> _components = new List<IOutfitComponent>();
        public OutfitSet(string name)
        {
            _setName = name;
        }
        public void Add(IOutfitComponent component)
        {
            _components.Add(component);
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine($" Набір: {_setName}");
            foreach (var component in _components)
            {
                component.DisplayInfo();
            }
        }
    }
}
