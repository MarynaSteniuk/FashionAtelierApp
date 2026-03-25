using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Flyweight
{
    public class PlasticButton : IButton
    {
        public void SewOn(string garmentName)
        {
            System.Console.WriteLine($" Пришито звичайний пластиковий ґудзик до: {garmentName}");
        }
    }
}
