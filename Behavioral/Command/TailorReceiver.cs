using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Command
{
    public class TailorReceiver
    {
        public void SewGarment(string garmentName)
        {
            System.Console.WriteLine($" Кравець шиє виріб: {garmentName}");
        }
        public void AddDecoration(string decorationType)
        {
            System.Console.WriteLine($" Кравець прикрашає виріб: {decorationType}");
        }
    }
}
