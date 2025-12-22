using COR.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR.ConcreteHandlers
{
    public class Director : ExpenseHandler
    {
        public override void HandleRequest(decimal amount)
        {
            if (amount <= 20000)
            {
                Console.WriteLine($"Director approved expense: {amount}");
            }
            else
            {
                _nextHandler?.HandleRequest(amount);
            }
        }
    }
}
