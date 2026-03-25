using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Facade
{
    public class AtelierFacade
    {
        private InventorySystem _inventory = new InventorySystem();
        private PaymentSystem _payment = new PaymentSystem();
        private TailoringSystem _tailor = new TailoringSystem();
        private DeliverySystem _delivery = new DeliverySystem();
        public void CompleteOrder()
        {
            System.Console.WriteLine("--- Початок обробки замовлення через Фасад ---");
            _inventory.ReserveFabric();
            _payment.ProcessPayment();
            _tailor.Sew();
            _delivery.Dispatch();
            System.Console.WriteLine("--- Замовлення успішно виконано! ---");
        }
    }
}
