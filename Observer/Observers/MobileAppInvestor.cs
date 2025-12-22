using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observers
{
    public class MobileAppInvestor : IInvestor
    {
        public void Update(string stockName, double price)
        {
            Console.WriteLine($"[Mobile App] {stockName} price updated to {price}");
        }
    }
}
