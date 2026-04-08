using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Observer
{
    public class ObserverClient
    {
        public void RunObserver()
        {
            System.Console.WriteLine("--- ТЕСТ: СПОСТЕРІГАЧ (OBSERVER) ---");
            var boutique = new BoutiquePublisher();
            var customer1 = new VipCustomer("Анна");
            var customer2 = new VipCustomer("Марія");
            var vogueMagazine = new FashionMagazine("Vogue Ukraine");
            boutique.Subscribe(customer1);
            boutique.Subscribe(customer2);
            boutique.Subscribe(vogueMagazine);
            boutique.ReleaseNewCollection("Осінь-Зима 2026");
            boutique.Unsubscribe(customer2);
            boutique.ReleaseNewCollection("Весняний круїз 2027");
        }
    }
}
