using BridgePattern.Entities;
using BridgePattern.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Abstraction
{
    public abstract class Notification<T> where T : Message
    {
        public T Message { get; set; }
        protected INotificationDispatcher<T> NotificationDispatcher { get; }
        public Notification(INotificationDispatcher<T> notificationDispatcher)
        {
            NotificationDispatcher = notificationDispatcher;
        }
        public abstract void Dispatch();
    }
}
