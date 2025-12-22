using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interface;

namespace Visitor.Elements
{
    public class Electronics : IShoppingItem
    {
        public decimal Price { get; }

        public Electronics(decimal price)
        {
            Price = price;
        }

        public void Accept(IShoppingCartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
