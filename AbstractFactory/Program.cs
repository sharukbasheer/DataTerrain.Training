
using AbstractFactory.Factories;
using AbstractFactory.Interfaces;

IPaymentGatewayFactory paypalfactory = new PaypalFactory();
paypalfactory.CreatePaymentProcessor().ProcessPayment(100);
paypalfactory.CreateRefundProcessor().ProcessRefund(100);

IPaymentGatewayFactory razorfactory = new RazorpayFactory();
razorfactory.CreatePaymentProcessor().ProcessPayment(100);
razorfactory.CreateRefundProcessor().ProcessRefund(100);
Console.ReadKey();
