using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.State
{
    public interface IOrderState
    {
        void ProceedToNextStep(DressOrderContext context);
        void Cancel(DressOrderContext context);
    }
}
