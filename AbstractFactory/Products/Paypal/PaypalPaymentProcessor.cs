using AbstractFactory.Interfaces;

namespace AbstractFactory.Products.Paypal
{
    public class PaypalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Paypal: Processing payment of {amount}");
        }
    }
}
