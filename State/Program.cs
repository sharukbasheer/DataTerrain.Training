
using State.Context;

var order = new OrderContext();

order.Ship();
order.Deliver();
order.Cancel();
Console.ReadKey();