using Mediator.Mediators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mediator.Colleagues
{
    public class PremiumUser : User
    {
        public PremiumUser(IChatMediator mediator, string name): base(mediator, name)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{Name} (Premium) received: {message}");
        }
    }
}
