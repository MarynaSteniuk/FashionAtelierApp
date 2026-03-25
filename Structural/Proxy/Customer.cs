using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Proxy
{
    public class Customer
    {
        public string Name { get; set; }
        public bool HasVipPass { get; set; }
        public Customer(string name, bool hasVipPass)
        {
            Name = name;
            HasVipPass = hasVipPass;
        }
    }
}
