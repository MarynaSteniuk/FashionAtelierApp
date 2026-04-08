using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Mediator.Departments
{
    public class DeliveryDepartment : BaseDepartment
    {
        public override void ReactToAction(AtelierAction action)
        {
            if (action == AtelierAction.SewingFinished)
            {
                System.Console.WriteLine(" Доставка: Прогріваємо авто, скоро забирати замовлення.");
            }
        }
    }
}
