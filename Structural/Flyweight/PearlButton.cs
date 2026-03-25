using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Flyweight
{
    public class PearlButton : IButton
    {
        public void SewOn(string garmentName)
        {
            System.Console.WriteLine($" Пришито елегантний перлинний ґудзик до: {garmentName}");
        }
    }
}
