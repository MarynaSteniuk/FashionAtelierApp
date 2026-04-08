using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.State
{
    public class ReadyState : IOrderState
    {
        public void ProceedToNextStep(DressOrderContext context)
        {
            System.Console.WriteLine(" Статус змінено: Клієнт забрав сукню. Замовлення успішно закрито!");
        }
        public void Cancel(DressOrderContext context)
        {
            System.Console.WriteLine(" Помилка: Сукня вже повністю готова! Скасувати замовлення неможливо.");
        }
    }
}
