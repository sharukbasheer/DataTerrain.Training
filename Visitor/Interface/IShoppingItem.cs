using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Interface
{
    public interface IShoppingItem
    {
        void Accept(IShoppingCartVisitor visitor);
    }
}
