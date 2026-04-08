using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Strategy
{
    public class CashPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            System.Console.WriteLine($" Оплата: {amount} грн прийнято готівкою на касі. Видаємо чек.");
        }
    }
}
