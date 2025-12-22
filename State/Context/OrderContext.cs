using State.Interface;
using State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Context
{
    public class OrderContext
    {
        public IOrderState CurrentState { get; set; }

        public OrderContext()
        {
            CurrentState = new PlacedState();
        }
        public void Ship()
        {
            CurrentState.Ship(this);
        }
        public void Deliver()
        {
            CurrentState.Deliver(this); 
        }
        public void Cancel() 
        {
            CurrentState.Cancel(this); 
        }


    }
}
