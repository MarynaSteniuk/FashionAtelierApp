using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Strategy
{
    public class StrategyClient
    {
        public void RunStrategy()
        {
            System.Console.WriteLine("--- ТЕСТ: СТРАТЕГІЯ (STRATEGY) ---");
            var checkout = new OrderCheckout();
            double orderAmount = 4500.00; 

            System.Console.WriteLine("Клієнт 1 хоче розрахуватися готівкою:");
            checkout.SetPaymentStrategy(new CashPayment());
            checkout.ProcessOrder(orderAmount);

            System.Console.WriteLine("\nКлієнт 2 хоче розрахуватися карткою:");
            checkout.SetPaymentStrategy(new CardPayment("4149-XXXX-XXXX-8899"));
            checkout.ProcessOrder(orderAmount);

            System.Console.WriteLine("\nКлієнт 3 (VIP) хоче списати бонуси:");
            checkout.SetPaymentStrategy(new BonusPayment("+38(099)123-45-67"));
            checkout.ProcessOrder(orderAmount);
        }
    }
}
