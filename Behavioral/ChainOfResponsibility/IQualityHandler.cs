using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.ChainOfResponsibility
{
    public interface IQualityHandler
    {
        IQualityHandler SetNext(IQualityHandler handler);
        string Handle(QualityCheckRequest request);
    }
}
