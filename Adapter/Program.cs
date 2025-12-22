using Adapter.Adapters;
using Adapter.Interfaces;
using Adapter.ThirdParty;

IPaymentService paymentService = new PaymentGatewayAdapter(new ThirdPartyPaymentGateway());
paymentService.MakePayment(100);

Console.ReadKey();