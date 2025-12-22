using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Subsystems
{
    public class NotificationService
    {
        public void SendConfirmation()
        {
            Console.WriteLine("Sending order confirmation...");
        }
    }
}
