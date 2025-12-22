using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Operations
{
    public class SmsSender : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }
}
