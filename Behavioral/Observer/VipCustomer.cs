using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Observer
{
    public class VipCustomer : IObserver
    {
        private string _name;
        public VipCustomer(string name)
        {
            _name = name;
        }
        public void Update(string collectionName)
        {
            System.Console.WriteLine($"   -> SMS для {_name}: Запрошуємо на примірку колекції '{collectionName}'!");
        }
    }
}
