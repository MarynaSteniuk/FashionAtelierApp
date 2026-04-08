using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FashionAtelierApp.Behavioral.Mediator.Departments;

namespace FashionAtelierApp.Behavioral.Mediator
{
    public interface IAtelierMediator
    {
        void AddDepartment(IDepartment department);
        void Act(IDepartment actor, AtelierAction action); 
    }
}
