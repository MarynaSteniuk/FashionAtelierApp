using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.ChainOfResponsibility
{
    public class ChainClient
    {
        public void RunChain()
        {
            System.Console.WriteLine("--- ТЕСТ: ЛАНЦЮЖОК ОБОВ'ЯЗКІВ ---");
            var tailor = new TailorHandler();
            var manager = new ManagerHandler();
            var director = new DirectorHandler();
            tailor.SetNext(manager).SetNext(director);
            var requests = new QualityCheckRequest[] {
                new QualityCheckRequest("Базова біла футболка", 1),
                new QualityCheckRequest("Діловий костюм-трійка", 2),
                new QualityCheckRequest("Ексклюзивна весільна сукня", 3),
                new QualityCheckRequest("Космічний скафандр для показу мод", 5) 
            };

            foreach (var request in requests)
            {
                System.Console.WriteLine($"\n[Запит] Перевірка виробу: {request.ItemName}");
                string result = tailor.Handle(request);
                System.Console.WriteLine($"[Результат] {result}");
            }
        }
    }
}
