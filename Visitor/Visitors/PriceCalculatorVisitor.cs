using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Elements;
using Visitor.Interface;

namespace Visitor.Visitors
{
    public class PriceCalculatorVisitor : IShoppingCartVisitor
    {
        public void Visit(Book book)
        {
            Console.WriteLine($"Book price: {book.Price }");
        }

        public void Visit(Electronics electronics)
        {
            Console.WriteLine($"Electronics price: {electronics.Price }");
        }
    }
}
