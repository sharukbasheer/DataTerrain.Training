using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Elements;

namespace Visitor.Interface
{
    public interface IShoppingCartVisitor
    {
        void Visit(Book book);
        void Visit(Electronics electronics);
    }
}
