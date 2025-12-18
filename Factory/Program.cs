
using FactoryMethod.Factory;
using FactoryMethod.Interface;

INotification email=NotificationFactory.CreateNotification("email");
email.Send("Hello");
INotification sms=NotificationFactory.CreateNotification("sms");
sms.Send("Hello");

Console.ReadKey();
