using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.ChainOfResponsibility
{
    public class TailorHandler : BaseQualityHandler
    {
        public override string Handle(QualityCheckRequest request)
        {
            if (request.Difficulty == 1)
            {
                return $" Головний кравець перевірив '{request.ItemName}'. Шви ідеальні!";
            }
            return base.Handle(request);
        }
    }
}
