using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Command
{
    public class CommandClient
    {
        public void RunCommand()
        {
            System.Console.WriteLine("--- ТЕСТ: КОМАНДА ---");
            TailorReceiver masterTailor = new TailorReceiver();
            ICommand makeDress = new SewCommand(masterTailor, "Вечірня сукня");
            ICommand makeSuit = new SewCommand(masterTailor, "Діловий костюм");
            ICommand addCrystals = new DecorateCommand(masterTailor, "Стрази Swarovski");
            AdministratorInvoker admin = new AdministratorInvoker();
            admin.TakeOrder(makeDress);
            admin.TakeOrder(addCrystals);
            admin.TakeOrder(makeSuit);
            admin.ProcessOrders();
        }
    }
}
