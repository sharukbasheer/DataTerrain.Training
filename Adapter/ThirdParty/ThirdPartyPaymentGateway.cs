using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.ThirdParty
{
    public class ThirdPartyPaymentGateway : IPaymentService
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"ThirdPartyPaymentGateway: Making payment of {amount}");
        }
    }
}
