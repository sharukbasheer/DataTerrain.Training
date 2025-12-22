using COR.ConcreteHandlers;

var manager = new Manager();
var director = new Director();
var cfo = new CEO();

manager.SetNext(director);
director.SetNext(cfo);

manager.HandleRequest(3000);
manager.HandleRequest(15000);
manager.HandleRequest(75000);
manager.HandleRequest(200000);

Console.ReadLine();