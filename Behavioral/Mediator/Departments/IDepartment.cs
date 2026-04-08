using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Mediator.Departments
{
    public interface IDepartment
    {
        void SetMediator(IAtelierMediator mediator);
        void Act(AtelierAction action); 
        void ReactToAction(AtelierAction action); 
    }
}
