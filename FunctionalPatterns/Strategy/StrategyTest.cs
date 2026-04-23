using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.FunctionalPatterns.Strategy
{
    public class StrategyTest
    {
        public static void Run()
        {
            var checkout = new FunctionalCheckout();

            Action<double> payByCash = amt => Console.WriteLine($"Готівка: {amt} грн.");
            Action<double> payByCard = amt => Console.WriteLine($"Картка: {amt} грн знято.");

            checkout.ProcessOrder(1000, payByCash);
            checkout.ProcessOrder(4500, payByCard);
            checkout.ProcessOrder(200, amt => Console.WriteLine($"Бонуси: списано {amt} балів."));
        }
    }
}
