using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observers
{
    public class EmailInvestor : IInvestor
    {
        public void Update(string stockName, double price)
        {
            Console.WriteLine($"[Email] {stockName} price updated to {price}");
        }
    }
}
