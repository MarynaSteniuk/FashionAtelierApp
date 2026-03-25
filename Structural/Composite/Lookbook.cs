using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace FashionAtelierApp.Structural.Composite
{
    public class Lookbook : IOutfitComponent
    {
        private string _collectionName;
        private List<IOutfitComponent> _components = new List<IOutfitComponent>();
        public Lookbook(string name)
        {
            _collectionName = name;
        }
        public void Add(IOutfitComponent component)
        {
            _components.Add(component);
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine($"\n=== ЛУКБУК: {_collectionName} ===");
            foreach (var component in _components)
            {
                component.DisplayInfo();
            }
        }
    }
}
