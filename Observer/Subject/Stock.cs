using Observer.Observers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Observer.Subject
{
    public class Stock : IStock
    {
        public Stock(string _name, double _price)
        {
            name = _name;
            price = _price;
        }

        private readonly List<IInvestor> _investors = new();

        public string name { get; }

        private double price;

        public void Notify()
        {
            foreach (var investor in _investors)
            {
                investor.Update(this.name, this.price);
            }
        }
        public void SetPrice(double price)
        {
            this.price = price;
            Notify();
        }
        public void Register(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Remove(IInvestor investor)
        {
            _investors.Remove(investor);

        }
    }
}
