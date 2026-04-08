using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.State
{
    public class NewOrderState : IOrderState
    {
        public void ProceedToNextStep(DressOrderContext context)
        {
            System.Console.WriteLine(" Статус змінено: Тканину розкроєно, почалося пошиття.");
            context.CurrentState = new InProductionState();
        }
        public void Cancel(DressOrderContext context)
        {
            System.Console.WriteLine(" Скасування: Замовлення ще не почали шити. Повертаємо 100% коштів.");
        }
    }
}
