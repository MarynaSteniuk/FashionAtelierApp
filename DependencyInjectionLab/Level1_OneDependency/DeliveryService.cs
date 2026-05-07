using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.DependencyInjectionLab
{
    public interface IDeliveryService
    {
        void DeliverOrder();
    }
    public class DeliveryService : IDeliveryService
    {
        private readonly ITransport _transport;
        public DeliveryService(ITransport transport)
        {
            _transport = transport;
        }

        public void DeliverOrder()
        {
            _transport.PrepareCar();
            Console.WriteLine(" Замовлення передано в службу доставки.");
        }
    }
}
