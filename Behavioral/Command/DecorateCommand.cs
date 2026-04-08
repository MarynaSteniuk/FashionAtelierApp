using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Command
{
    public class DecorateCommand : ICommand
    {
        private TailorReceiver _receiver;
        private string _decoration;
        public DecorateCommand(TailorReceiver receiver, string decoration)
        {
            _receiver = receiver;
            _decoration = decoration;
        }
        public void Execute()
        {
            _receiver.AddDecoration(_decoration);
        }
    }
}
