using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Iterator
{
    public class FabricIterator : IFabricIterator
    {
        private FabricCatalog _catalog;
        private int _position = 0;
        public FabricIterator(FabricCatalog catalog)
        {
            _catalog = catalog;
        }
        public bool HasNext()
        {
            return _position < _catalog.Count;
        }
        public FabricItem Next()
        {
            FabricItem fabric = _catalog.GetFabricAt(_position);
            _position++;
            return fabric;
        }
    }
}
