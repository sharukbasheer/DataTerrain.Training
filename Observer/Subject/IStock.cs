using Observer.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subject
{
    public interface IStock
    {
        void Register(IInvestor investor);
        void Remove(IInvestor investor);
        void Notify();
    }
}
