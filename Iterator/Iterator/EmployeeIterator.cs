using Iterator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterator
{
    public class EmployeeIterator : IIterator<Employee>
    {
        private readonly List<Employee> _employees;
        private int _currentIndex = 0;

        public EmployeeIterator(List<Employee> employees)
        {
            _employees = employees;
        }

        public bool HasNext()
        {
            return _currentIndex < _employees.Count;
        }

        public Employee Next()
        {
            return _employees[_currentIndex++];
        }
    }
}
