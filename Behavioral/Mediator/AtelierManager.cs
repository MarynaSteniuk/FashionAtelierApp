using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using FashionAtelierApp.Behavioral.Mediator.Departments;

namespace FashionAtelierApp.Behavioral.Mediator
{
    public class AtelierManager : IAtelierMediator
    {
        private List<IDepartment> _departments = new List<IDepartment>();
        public void AddDepartment(IDepartment department)
        {
            _departments.Add(department);
            department.SetMediator(this);
        }
        public void Act(IDepartment actor, AtelierAction action)
        {
            System.Console.WriteLine($"\n[МЕНЕДЖЕР]: Отримав сигнал {action}. Сповіщаю інші відділи...");
            foreach (var dept in _departments)
            {
                if (dept != actor)
                {
                    dept.ReactToAction(action);
                }
            }
        }
    }
}
