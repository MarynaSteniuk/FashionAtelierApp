using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FashionAtelierApp.FunctionalPatterns.ExecuteAround
{
    public class SewingMachine
    {
        private SewingMachine() { Console.WriteLine("\nШвейну машинку УВІМКНЕНО."); }
        public void Sew(string item) { Console.WriteLine($"   Шиємо: {item}"); }
        private void TurnOff() { Console.WriteLine("Швейну машинку ВИМКНЕНО."); }
        public static void Use(Action<SewingMachine> action)
        {
            var machine = new SewingMachine();
            try
            {
                action(machine);
            }
            finally
            {
                machine.TurnOff();
            }
        }
    }
}
