using CompositeMethod.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMethod.Composite
{
    public class Manager : IEmployee
    {
        private readonly string _name;
        private readonly List<IEmployee> _employees = new List<IEmployee>();
        public Manager(string name)
        {
            _name= name;
        }

        public void AddEmployee(IEmployee employee)
        {
            _employees.Add(employee);

        }
        public void RemoveEmployee(IEmployee employee)
        {
            _employees.Remove(employee);
        }

        public void DisplayDetails()
        {
            foreach (var employee in _employees)
            {
                employee.DisplayDetails();
            }
        }
    }
}
