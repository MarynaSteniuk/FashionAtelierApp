using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Iterator
{
    public interface IFabricCollection
    {
        IFabricIterator CreateIterator();
    }
}
