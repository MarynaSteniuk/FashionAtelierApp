using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.State
{
    public class DressOrderContext
    {
        public string ClientName { get; }
        public IOrderState CurrentState { get; set; }
        public DressOrderContext(string clientName)
        {
            ClientName = clientName;
            CurrentState = new NewOrderState();
            System.Console.WriteLine($"\n[Система]: Створено нове замовлення для клієнта {ClientName}.");
        }
        public void NextStep()
        {
            CurrentState.ProceedToNextStep(this);
        }
        public void CancelOrder()
        {
            CurrentState.Cancel(this);
        }
    }
}
