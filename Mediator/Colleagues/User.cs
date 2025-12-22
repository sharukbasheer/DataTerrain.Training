using Mediator.Mediators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Colleagues
{
    public abstract class User
    {
        protected readonly IChatMediator _mediator;
        public string Name { get; }

        protected User(IChatMediator mediator, string name)
        {
            _mediator = mediator;
            Name = name;
        }

        public void Send(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");
            _mediator.SendMessage(message, this);
        }

        public abstract void Receive(string message);
    }
}
