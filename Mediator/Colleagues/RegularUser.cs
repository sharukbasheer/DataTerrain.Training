using Mediator.Mediators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Colleagues
{
    public class RegularUser : User
    {
        public RegularUser(IChatMediator mediator, string name): base(mediator, name)
        {

        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{Name} received: {message}");
        }
    }
}
