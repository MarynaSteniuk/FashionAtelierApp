using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Composite
{
    public class FashionShow
    {
        public void StartShow(IOutfitComponent component)
        {
            System.Console.WriteLine(" Розпочинаємо модний показ! ");
            component.DisplayInfo();
        }
    }
}
