using State.Context;
using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class DeliveredState : IOrderState
    {
        public void Ship(OrderContext context)
        {
            Console.WriteLine("Order already delivered.");
        }

        public void Deliver(OrderContext context)
        {
            Console.WriteLine("Order already delivered.");
        }

        public void Cancel(OrderContext context)
        {
            Console.WriteLine("Cannot cancel after delivery.");
        }
    }
}
