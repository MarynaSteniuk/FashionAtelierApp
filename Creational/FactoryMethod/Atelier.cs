using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.FactoryMethod
{
    public abstract class Atelier
    {
        public abstract IGarment CreateGarment();
    }
}