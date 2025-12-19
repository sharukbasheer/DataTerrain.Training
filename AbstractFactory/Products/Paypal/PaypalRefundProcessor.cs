using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Paypal
{
    public class PaypalRefundProcessor : IRefundProcessor
    {
        public void ProcessRefund(decimal amount)
        {
            Console.WriteLine($"Paypal: Refunding {amount}");
        }
    }
}
