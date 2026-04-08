using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace FashionAtelierApp.Behavioral.Memento
{
    public class DesignerHistory
    {
        private Stack<DesignMemento> _history = new Stack<DesignMemento>();
        public void Backup(DesignMemento memento)
        {
            _history.Push(memento);
        }
        public DesignMemento Undo()
        {
            if (_history.Count == 0)
            {
                return null;
            }
            return _history.Pop();
        }
    }
}
