using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Strategy
{
    public class BonusPayment : IPaymentStrategy
    {
        private string _clientPhone;
        public BonusPayment(string clientPhone)
        {
            _clientPhone = clientPhone;
        }
        public void Pay(double amount)
        {
            System.Console.WriteLine($" Оплата: {amount} грн списано з бонусного рахунку за номером {_clientPhone}.");
        }
    }
}
