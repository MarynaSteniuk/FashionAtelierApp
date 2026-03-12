using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.Prototype
{
    public interface IClothingPattern
    {
        IClothingPattern Clone();
    }
}
