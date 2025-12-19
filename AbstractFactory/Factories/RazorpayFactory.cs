using AbstractFactory.Interfaces;
using AbstractFactory.Products.Razorpay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class RazorpayFactory : IPaymentGatewayFactory
    {
        public IPaymentProcessor CreatePaymentProcessor()
        {
            return new RazorpayPaymentProcessor();
        }

        public IRefundProcessor CreateRefundProcessor()
        {
            return new RazorpayRefundProcessor();
        }
    }
}
