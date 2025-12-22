using State.Context;
using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class PlacedState : IOrderState
    {
        public void Ship(OrderContext context)
        {
            Console.WriteLine("Order shipped.");
            context.CurrentState = new ShippedState();
        }

        public void Deliver(OrderContext context)
        {
            Console.WriteLine("Order cannot be delivered before shipping.");
        }

        public void Cancel(OrderContext context)
        {
            Console.WriteLine("Order cancelled.");
            context.CurrentState = new CancelledState();
        }
    }
}
