using System;
using System.Collections.Generic;
using FashionAtelierApp.Creational.FactoryMethod;

namespace FashionAtelierApp.FunctionalPatterns.FactoryMethod
{
    public class FunctionalAtelier
    {
        private readonly Dictionary<string, Func<IGarment>> _factories = new();
        public FunctionalAtelier()
        {
            _factories.Add("Coat", () => new Coat());
            _factories.Add("Dress", () => new Dress());
        }
        public IGarment CreateGarment(string type)
        {
            if (_factories.ContainsKey(type))
            {
                return _factories[type]();
            }
            throw new ArgumentException("Невідомий тип одягу");
        }
    }
}
