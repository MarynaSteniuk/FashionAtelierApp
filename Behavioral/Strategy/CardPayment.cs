using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Strategy
{
    public class CardPayment : IPaymentStrategy
    {
        private string _cardNumber;
        public CardPayment(string cardNumber)
        {
            _cardNumber = cardNumber;
        }
        public void Pay(double amount)
        {
            System.Console.WriteLine($" Оплата: {amount} грн знято з банківської картки {_cardNumber}.");
        }
    }
}
