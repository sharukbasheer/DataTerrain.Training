using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Abstraction
{
    public abstract class Notification
    {
        protected readonly INotificationSender _notificationSender;
        public Notification(INotificationSender notificationSender)
        {
            _notificationSender=notificationSender;
        }

        public abstract void Notify(string message);
    }
}
