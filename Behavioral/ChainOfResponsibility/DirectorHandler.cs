using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.ChainOfResponsibility
{
    public class DirectorHandler : BaseQualityHandler
    {
        public override string Handle(QualityCheckRequest request)
        {
            if (request.Difficulty >= 3)
            {
                return $" ДИРЕКТОР особисто перевірив '{request.ItemName}'. Ексклюзивна якість підтверджена!";
            }
            return base.Handle(request);
        }
    }
}
