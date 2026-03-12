using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.Builder
{
    public class FashionDirector
    {
        public void Construct(IDressBuilder builder)
        {
            builder.SetFabric();
        }
    }
}
