using Strategy.Context;
using Strategy.Strategies;

PaymentContext paymentContext = new PaymentContext();

paymentContext.SetPaymentStrategy(new CreditCardPayment());
paymentContext.ProcessPayment(100);

paymentContext.SetPaymentStrategy(new UpiPayment());
paymentContext.ProcessPayment(2000);

paymentContext.SetPaymentStrategy(new NetBankingPayment());
paymentContext.ProcessPayment(10000);

Console.ReadKey();