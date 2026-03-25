using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Proxy
{
    public class VIPCollectionProxy : ICollectionAccess
    {
        private VIPCollection _realCollection;
        private Customer _customer;
        public VIPCollectionProxy(Customer customer)
        {
            _customer = customer;
        }
        public string ViewCollection()
        {
            if (!_customer.HasVipPass)
            {
                return $"Клієнту {_customer.Name} відмовлено в доступі. Потрібна VIP-перепустка.";
            }
            if (_realCollection == null)
            {
                _realCollection = new VIPCollection();
            }
            System.Console.WriteLine($" Доступ дозволено для клієнта {_customer.Name}.");
            return _realCollection.ViewCollection();
        }
    }
}
