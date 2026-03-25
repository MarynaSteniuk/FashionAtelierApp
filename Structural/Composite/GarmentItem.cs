using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Composite
{
    public class GarmentItem : IOutfitComponent
    {
        private string _name;

        public GarmentItem(string name)
        {
            _name = name;
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine($"   - Окрема річ: {_name}");
        }
    }
}
