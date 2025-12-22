using COR.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR.ConcreteHandlers
{
    public class Manager : ExpenseHandler
    {
        public override void HandleRequest(decimal amount)
        {
            if (amount <= 5000)
            {
                Console.WriteLine($"Manager approved expense: {amount}");
            }
            else
            {
                _nextHandler?.HandleRequest(amount);
            }
        }
    }
}
