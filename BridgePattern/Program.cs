using BridgePattern.Abstraction;
using BridgePattern.ConcreteImplementor;
using BridgePattern.Entities;
using BridgePattern.Implementor;
using BridgePattern.RefinedAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificationDispatcher<Message> smsDispatcher = new SmsDispatcher();
            Notification<Message> smsNotification = new FriendNotification<Message>(smsDispatcher)
            {
                Message = new Message()
                {
                    From = "999000111",
                    To = "999444888",
                    Content = "You've received a friend request"
                }
            };
            smsNotification.Dispatch();
            
            INotificationDispatcher<EmailMessage> emailDispatcher = new EmailDispatcher();
            Notification<EmailMessage> emailNotification = new FriendNotification<EmailMessage>(emailDispatcher)
            {
                Message = new EmailMessage()
                {
                    From = "rmaldonado@designpatterns.com",
                    To = "friend@testing.com",
                    Content = "You've received a friend request",
                    Subject = "New friend request"
                }
                
            };
            emailNotification.Dispatch();

            Console.ReadKey();


        }
    }
}
