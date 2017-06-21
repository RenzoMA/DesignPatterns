using BridgePattern.Entities;
using BridgePattern.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.ConcreteImplementor
{
    class EmailDispatcher : INotificationDispatcher<EmailMessage>
    {
        public void DispatchNotification(EmailMessage message)
        {
            Console.WriteLine(
                    String.Format(
                        "\n\n -- EMAIL MESSAGE -- \n\n" +
                        "from: {0} \n" +
                        "to: {1} \n" +
                        "subject: {2} \n\n" +
                        "{3}", message.From, message.To, message.Subject, message.Content)); ;
        }
    }
}
