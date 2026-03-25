using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Adapter
{
    internal class EuropeanTailor
    {
        public string Sew(IMetricSystem metrics)
        {
            return $"Кравець зшив сукню. Мірка: {metrics.GetBustSizeCm()} см.";
        }
    }
}
