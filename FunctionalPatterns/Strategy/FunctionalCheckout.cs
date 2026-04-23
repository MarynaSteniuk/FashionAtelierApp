using System;

namespace FashionAtelierApp.FunctionalPatterns.Strategy
{
    public class FunctionalCheckout
    {
        public void ProcessOrder(double amount, Action<double> paymentStrategy)
        {
            Console.WriteLine("\n[Каса]: Обробка замовлення...");
            paymentStrategy(amount);
        }
    }
}