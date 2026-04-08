using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FashionAtelierApp.Behavioral.Mediator.Departments;

namespace FashionAtelierApp.Behavioral.Mediator
{
    public class MediatorClient
    {
        public void RunMediator()
        {
            System.Console.WriteLine("--- ТЕСТ: ПОСЕРЕДНИК (ІЗ ПІДПАПКОЮ) ---");
            var manager = new AtelierManager();
            var tailor = new TailorDepartment();
            var boutique = new BoutiqueDepartment();
            var delivery = new DeliveryDepartment();
            manager.AddDepartment(tailor);
            manager.AddDepartment(boutique);
            manager.AddDepartment(delivery);
            tailor.Act(AtelierAction.SewingFinished);
        }
    }
}
