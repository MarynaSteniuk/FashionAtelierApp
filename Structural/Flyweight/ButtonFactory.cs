using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace FashionAtelierApp.Structural.Flyweight
{
    public class ButtonFactory
    {
        private Dictionary<ButtonType, IButton> _buttons = new Dictionary<ButtonType, IButton>();
        public IButton GetButton(ButtonType type)
        {
            if (!_buttons.ContainsKey(type))
            {
                if (type == ButtonType.Plastic) _buttons[type] = new PlasticButton();
                else if (type == ButtonType.Metal) _buttons[type] = new MetalButton();
                else if (type == ButtonType.Pearl) _buttons[type] = new PearlButton();

                System.Console.WriteLine($"   [ФАБРИКА]: Створено НОВИЙ екземпляр ґудзика типу {type}");
            }
            return _buttons[type];
        }
        public int GetCacheSize()
        {
            return _buttons.Count;
        }
    }
}
