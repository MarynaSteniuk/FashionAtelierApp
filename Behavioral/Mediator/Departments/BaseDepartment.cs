using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Mediator.Departments
{
    public abstract class BaseDepartment : IDepartment
    {
        protected IAtelierMediator? _mediator;
        public void SetMediator(IAtelierMediator mediator)
        {
            _mediator = mediator;
        }
        public void Act(AtelierAction action)
        {
            System.Console.WriteLine($"\n> {this.GetType().Name} ініціює: {action}");
            _mediator?.Act(this, action); 
        }
        public abstract void ReactToAction(AtelierAction action);
    }
}
