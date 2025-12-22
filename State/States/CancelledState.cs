using State.Context;
using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class CancelledState : IOrderState
    {
        public void Ship(OrderContext context)
        {
            Console.WriteLine("Order is cancelled.");
        }

        public void Deliver(OrderContext context)
        {
            Console.WriteLine("Order is cancelled.");
        }

        public void Cancel(OrderContext context)
        {
            Console.WriteLine("Order already cancelled.");
        }
    }
}
