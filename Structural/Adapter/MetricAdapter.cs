using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Adapter
{
    public class MetricAdapter : IMetricSystem
    {
        private ImperialSystem _imperialSystem;

        public MetricAdapter(ImperialSystem imperialSystem)
        {
            _imperialSystem = imperialSystem;
        }
        public double GetBustSizeCm()
        {
            return _imperialSystem.GetBustSizeInches() * 2.54;
        }
    }
}
