using Iterator.Iterator;
using Iterator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Aggregate
{
    public class EmployeeCollection : IEmployeeCollection
    {
        private readonly List<Employee> _employees = new();

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public IIterator<Employee> CreateIterator()
        {
            return new EmployeeIterator(_employees);
        }
    }
}
