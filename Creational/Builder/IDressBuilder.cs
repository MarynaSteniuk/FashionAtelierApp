using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Creational.Builder
{
    public interface IDressBuilder
    {
        void SetFabric();
        CustomDress GetResult();
    }
}