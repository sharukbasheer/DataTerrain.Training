using Visitor.Elements;
using Visitor.Interface;
using Visitor.Visitors;

var items = new List<IShoppingItem>{ new Book(500),new Electronics(20000) };
var visitor = new PriceCalculatorVisitor();
foreach (var item in items)
{
    item.Accept(visitor);
}

Console.ReadKey();