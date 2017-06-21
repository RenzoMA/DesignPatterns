using BridgePattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgePattern.Implementor;
using BridgePattern.Entities;

namespace BridgePattern.RefinedAbstraction
{
    class FriendNotification<T>  : Notification<T> where T : Message
    {
        public FriendNotification(INotificationDispatcher<T> notificationDispatcher) : base(notificationDispatcher)
        {

        }

        public override void Dispatch()
        {
            NotificationDispatcher.DispatchNotification(Message);
        }
    }
}
