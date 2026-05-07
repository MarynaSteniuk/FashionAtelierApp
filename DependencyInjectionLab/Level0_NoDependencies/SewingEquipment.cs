using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.DependencyInjectionLab
{
    public interface ISewingEquipment
    {
        void TurnOn();
    }
    public class SewingEquipment : ISewingEquipment
    {
        public void TurnOn()
        {
            Console.WriteLine(" Швейне обладнання увімкнено.");
        }
    }
}