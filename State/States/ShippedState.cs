using State.Context;
using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class ShippedState : IOrderState
    {
        public void Ship(OrderContext context)
        {
            Console.WriteLine("Order already shipped.");
        }

        public void Deliver(OrderContext context)
        {
            Console.WriteLine("Order delivered.");
            context.CurrentState = new DeliveredState();
        }

        public void Cancel(OrderContext context)
        {
            Console.WriteLine("Cannot cancel after shipping.");
        }
    }
}
