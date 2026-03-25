using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Structural.Flyweight
{
    public class TailorsDesk
    {
        private ButtonFactory _factory;
        public TailorsDesk(ButtonFactory factory)
        {
            _factory = factory;
        }
        public void SewButtonToGarment(ButtonType type, string garment)
        {
            IButton button = _factory.GetButton(type);
            button.SewOn(garment);
        }
    }
}
