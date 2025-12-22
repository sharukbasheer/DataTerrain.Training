using Mediator.Colleagues;
using Mediator.Mediators;

IChatMediator chatRoom = new ChatRoom();

var user1 = new RegularUser(chatRoom, "Sharuk");
var user2 = new PremiumUser(chatRoom, "Saravana");

chatRoom.RegisterUser(user1);
chatRoom.RegisterUser(user2);

user1.Send("Hello everyone!");
Console.WriteLine();
user2.Send("Welcome to the chat!"); 


Console.ReadKey();