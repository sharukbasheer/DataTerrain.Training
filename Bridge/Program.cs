

using Bridge.Abstraction;
using Bridge.Abstraction.Types;
using Bridge.Operations;

Notification notificationE = new InfoNotification(new EmailSender());
Notification notificationS=new InfoNotification(new SmsSender());
notificationE.Notify("Hi from email");
notificationS.Notify("Hi from SMS");
Console.ReadKey();