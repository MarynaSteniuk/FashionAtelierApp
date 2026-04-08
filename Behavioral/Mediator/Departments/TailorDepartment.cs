using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Mediator.Departments
{
    public class TailorDepartment : BaseDepartment
    {
        public override void ReactToAction(AtelierAction action)
        {
            if (action == AtelierAction.DeliveryStarted)
            {
                System.Console.WriteLine(" Цех: Зрозумів, річ поїхала. Звільняю місце на столі.");
            }
        }
    }
}

