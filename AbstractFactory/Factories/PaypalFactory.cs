using AbstractFactory.Interfaces;
using AbstractFactory.Products.Paypal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class PaypalFactory : IPaymentGatewayFactory
    {
        public IPaymentProcessor CreatePaymentProcessor()
        {
            return new PaypalPaymentProcessor();
        }

        public IRefundProcessor CreateRefundProcessor()
        {
            return new PaypalRefundProcessor();
        }
    }
}
