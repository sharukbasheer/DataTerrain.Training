using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR.Handler
{
    public abstract class ExpenseHandler
    {
        protected ExpenseHandler _nextHandler;

        public void SetNext(ExpenseHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void HandleRequest(decimal amount);
    }
}
