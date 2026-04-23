using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FashionAtelierApp.FunctionalPatterns.ExecuteAround
{
    public class ExecuteAroundTest
    {
        public static void Run()
        {
            SewingMachine.Use(machine =>
            {
                machine.Sew("Вечірня сукня");
                machine.Sew("Шовковий шарф");
            });
        }
    }
}
