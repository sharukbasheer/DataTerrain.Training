using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Abstraction.Types
{
    public class InfoNotification : Notification
    {
        public InfoNotification(INotificationSender sender) : base(sender)
        {

        }
        public override void Notify(string message)
        {
            _notificationSender.SendNotification($"Info: {message}");
        }
    }
}
