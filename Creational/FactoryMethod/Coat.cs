using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.FactoryMethod
{
    public class Coat : IGarment
    {
        public string GetDescription() => "Вовняне пальто";
    }
}
