using BridgePattern.Entities;
using BridgePattern.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.ConcreteImplementor
{
    class SmsDispatcher : INotificationDispatcher <Message>
    {
        public void DispatchNotification(Message message)
        {
            Console.WriteLine(
                String.Format("\n\n -- TEXT MESSAGE -- \n\n" +
                              "from {0} to {1}: \n" +
                              "{2}", message.From, message.To, message.Content));
        }
    }
}
