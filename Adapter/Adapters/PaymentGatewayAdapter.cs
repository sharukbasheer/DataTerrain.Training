using Adapter.Interfaces;
using Adapter.ThirdParty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapters
{
    public class PaymentGatewayAdapter : IPaymentService
    {
        private readonly ThirdPartyPaymentGateway _paymentGateway;
        public PaymentGatewayAdapter(ThirdPartyPaymentGateway paymentGateway)
        {
            this._paymentGateway = paymentGateway;
        }
        public void MakePayment(decimal amount)
        {
           _paymentGateway.MakePayment(amount);
        }
    }
}
