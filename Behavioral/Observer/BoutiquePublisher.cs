using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace FashionAtelierApp.Behavioral.Observer
{
    public class BoutiquePublisher : ISubject
    {
        private List<IObserver> _subscribers = new List<IObserver>();
        private string? _latestCollection;
        public void Subscribe(IObserver observer)
        {
            _subscribers.Add(observer);
            System.Console.WriteLine(" [Система]: Додано нового підписника.");
        }
        public void Unsubscribe(IObserver observer)
        {
            _subscribers.Remove(observer);
            System.Console.WriteLine(" [Система]: Підписника видалено.");
        }
        public string? Get_latestCollection()
        {
            return _latestCollection;
        }
        public void NotifySubscribers(string? _latestCollection)
        {
            System.Console.WriteLine($"\n РОЗСИЛКА НОВИН: Вийшла колекція '{_latestCollection}'!");
            foreach (var observer in _subscribers)
            {
                observer.Update(collectionName: _latestCollection);
            }
        }
        public void ReleaseNewCollection(string collectionName)
        {
            _latestCollection = collectionName;
            System.Console.WriteLine($"\n БУТИК: Офіційний реліз колекції '{collectionName}'!");

            NotifySubscribers(Get_latestCollection());
        }
        public void NotifySubscribers()
        {
            throw new NotImplementedException();
        }
    }
}
