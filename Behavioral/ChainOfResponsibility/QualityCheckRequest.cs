using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.ChainOfResponsibility
{
    public class QualityCheckRequest
    {
        public string ItemName { get; set; }
        public int Difficulty { get; set; }
        public QualityCheckRequest(string name, int difficulty)
        {
            ItemName = name;
            Difficulty = difficulty;
        }
    }
}
