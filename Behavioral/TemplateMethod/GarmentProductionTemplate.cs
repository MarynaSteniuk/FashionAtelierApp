using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.TemplateMethod
{
    public abstract class GarmentProductionTemplate
    {
        public void ManufactureGarment()
        {
            TakeMeasurements();
            CutFabric();
            SewGarment();
            AddDecorations(); 
            PackageGarment();
            System.Console.WriteLine("--- Виробництво завершено ---");
        }
        protected void TakeMeasurements()
        {
            System.Console.WriteLine(" Зняття базових мірок клієнта.");
        }
        protected abstract void CutFabric();
        protected abstract void SewGarment();

        protected virtual void AddDecorations()
        {
           
        }
        protected void PackageGarment()
        {
            System.Console.WriteLine(" Пакування виробу у фірмовий пакет Ательє.");
        }
    }
}
