using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FashionAtelierApp.Behavioral.State
{
    public class InProductionState : IOrderState
    {
        public void ProceedToNextStep(DressOrderContext context)
        {
            System.Console.WriteLine(" Статус змінено: Пошиття завершено. Сукня чекає на примірку!");
            context.CurrentState = new ReadyState();
        }
        public void Cancel(DressOrderContext context)
        {
            System.Console.WriteLine(" Скасування: Сукня вже шиється! Скасовуємо, але утримуємо 30% за зіпсовану тканину.");
        }
    }
}
