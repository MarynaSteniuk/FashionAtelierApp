using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.State
{
    public class StateClient
    {
        public void RunState()
        {
            System.Console.WriteLine("--- ТЕСТ: СТАН (STATE) ---");
            var order1 = new DressOrderContext("Олена");
            order1.NextStep(); 
            order1.NextStep(); 
            order1.NextStep();
            order1.CancelOrder();

            var order2 = new DressOrderContext("Дарина");
            order2.NextStep(); 
            order2.CancelOrder(); 
        }
    }
}
