using BridgePattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implementor
{
    public interface INotificationDispatcher<T> where T : Message
    {
        void DispatchNotification(T message) ;
    }
}
