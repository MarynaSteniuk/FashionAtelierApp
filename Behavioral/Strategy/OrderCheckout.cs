using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Strategy
{
    public class OrderCheckout
    {
        private IPaymentStrategy? _paymentStrategy;
        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy;
        }
        public void ProcessOrder(double amount)
        {
            if (_paymentStrategy == null)
            {
                System.Console.WriteLine(" Помилка: Будь ласка, оберіть спосіб оплати!");
                return;
            }
            System.Console.WriteLine("\n[Каса]: Обробка замовлення...");
            _paymentStrategy.Pay(amount);
        }
    }
}
