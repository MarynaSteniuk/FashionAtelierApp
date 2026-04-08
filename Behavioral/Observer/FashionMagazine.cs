using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Observer
{
    public class FashionMagazine : IObserver
    {
        private string _magazineName;
        public FashionMagazine(string name)
        {
            _magazineName = name;
        }
        public void Update(string collectionName)
        {
            System.Console.WriteLine($"   -> Журнал '{_magazineName}': Готуємо статтю про нові тренди з '{collectionName}'.");
        }
    }
}
