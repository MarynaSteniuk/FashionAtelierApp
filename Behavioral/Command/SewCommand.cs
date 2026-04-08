using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionAtelierApp.Behavioral.Command
{
    public class SewCommand : ICommand
    {
        private TailorReceiver _receiver;
        private string _garmentToSew;
        public SewCommand(TailorReceiver receiver, string garmentToSew)
        {
            _receiver = receiver;
            _garmentToSew = garmentToSew;
        }
        public void Execute()
        {
            _receiver.SewGarment(_garmentToSew);
        }
    }
}
