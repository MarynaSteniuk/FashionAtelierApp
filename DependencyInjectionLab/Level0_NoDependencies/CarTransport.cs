using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.DependencyInjectionLab
{
    public interface ITransport
    {
        void PrepareCar();
    }
    public class CarTransport : ITransport
    {
        public void PrepareCar()
        {
            Console.WriteLine(" Автомобіль для доставки готовий.");
        }
    }
}
