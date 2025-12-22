using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Abstraction.Types
{
    public class AlertNotification : Notification
    {
        public AlertNotification(INotificationSender _sender) : base(_sender)
        {

        }
        public override void Notify(string message)
        {
            _notificationSender.SendNotification($"Alert: {message}");
        }
    }
}
