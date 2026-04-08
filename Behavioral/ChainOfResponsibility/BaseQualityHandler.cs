using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.ChainOfResponsibility
{
    public abstract class BaseQualityHandler : IQualityHandler
    {
        private IQualityHandler? _nextHandler;

        public IQualityHandler SetNext(IQualityHandler handler)
        {
            _nextHandler = handler;
            return handler; 
        }
        public virtual string Handle(QualityCheckRequest request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            return $"Запит '{request.ItemName}' залишився без перевірки.";
        }
    }
}
