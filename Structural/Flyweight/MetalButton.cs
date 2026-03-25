using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Flyweight
{
    public class MetalButton : IButton
    {
        public void SewOn(string garmentName)
        {
            System.Console.WriteLine($" Пришито важкий металевий ґудзик до: {garmentName}");
        }
    }
}
