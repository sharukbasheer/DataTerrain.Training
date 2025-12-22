using State.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Interface
{
    public interface IOrderState
    {
        void Ship(OrderContext context);
        void Deliver(OrderContext context);
        void Cancel(OrderContext context);
    }
}
