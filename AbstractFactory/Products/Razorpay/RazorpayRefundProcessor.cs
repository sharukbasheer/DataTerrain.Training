using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Razorpay
{
    public class RazorpayRefundProcessor : IRefundProcessor
    {
        public void ProcessRefund(decimal amount)
        {
            Console.WriteLine($"Razorpay: Refunding {amount}");
        }
    }
}
