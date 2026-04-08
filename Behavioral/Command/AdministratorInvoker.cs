using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace FashionAtelierApp.Behavioral.Command
{
    public class AdministratorInvoker
    {
        private List<ICommand> _ordersQueue = new List<ICommand>();
        public void TakeOrder(ICommand command)
        {
            _ordersQueue.Add(command);
            System.Console.WriteLine("[Адміністратор]: Завдання додано до черги.");
        }
        public void ProcessOrders()
        {
            System.Console.WriteLine("\n[Адміністратор]: Передаю всі завдання в цех!");
            foreach (var command in _ordersQueue)
            {
                command.Execute(); 
            }
            _ordersQueue.Clear(); 
        }
    }
}
