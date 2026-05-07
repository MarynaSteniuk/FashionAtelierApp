using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.DependencyInjectionLab
{
    public class OrderProcessor
    {
        private readonly ITailorService _tailor;
        private readonly IDeliveryService _delivery;
        private readonly ILogger _logger;
        public OrderProcessor(ITailorService tailor, IDeliveryService delivery, ILogger logger)
        {
            _tailor = tailor;
            _delivery = delivery;
            _logger = logger;
        }
        public void ProcessNewOrder()
        {
            _logger.Log("Отримано нове замовлення. Починаємо обробку...");
            _tailor.SewGarment();
            _delivery.DeliverOrder();
            _logger.Log("Замовлення успішно виконано та відправлено клієнту!");
        }
    }
}
