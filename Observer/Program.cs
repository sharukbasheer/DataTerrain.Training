using Observer.Observers;
using Observer.Subject;

var stock = new Stock("DATATERRAIN", 1200);

var mobileUser = new MobileAppInvestor();
var emailUser = new EmailInvestor();

stock.Register(mobileUser);
stock.Register(emailUser);

stock.SetPrice(1250);
stock.SetPrice(1300);

Console.ReadKey();