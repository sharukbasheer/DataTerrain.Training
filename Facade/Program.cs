using Facade.Facades;

var orderFacade = new OrderFacade();
orderFacade.PlaceOrder("Product", 2500);
Console.ReadKey();