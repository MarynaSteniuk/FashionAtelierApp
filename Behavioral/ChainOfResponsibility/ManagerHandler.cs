using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.ChainOfResponsibility
{
    public class ManagerHandler : BaseQualityHandler
    {
        public override string Handle(QualityCheckRequest request)
        {
            if (request.Difficulty == 2)
            {
                return $"Менеджер перевірив '{request.ItemName}'. Комплектація та декор у нормі!";
            }
            return base.Handle(request);
        }
    }
}
