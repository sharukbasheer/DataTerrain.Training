using COR.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR.ConcreteHandlers
{
    public class CEO : ExpenseHandler
    {
        public override void HandleRequest(decimal amount)
        {
            if (amount <= 100000)
            {
                Console.WriteLine($"CFO approved expense: {amount}");
            }
            else
            {
                Console.WriteLine($"Expense {amount} requires board approval.");
            }
        }
    }
}
