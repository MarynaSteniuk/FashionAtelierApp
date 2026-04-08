using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace FashionAtelierApp.Behavioral.Iterator
{
    public class FabricCatalog : IFabricCollection
    {
        private List<FabricItem> _fabrics = new List<FabricItem>();

        public void AddFabric(FabricItem fabric)
        {
            _fabrics.Add(fabric);
        }

        public int Count => _fabrics.Count;
        public FabricItem GetFabricAt(int index)
        {
            return _fabrics[index];
        }
        public IFabricIterator CreateIterator()
        {
            return new FabricIterator(this);
        }
    }
}

