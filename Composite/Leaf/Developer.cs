using CompositeMethod.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMethod.Leaf
{
    public class Developer : IEmployee
    {
        private readonly string name;
        private readonly string role;
        public Developer(string _name, string _role)
        {
            this.name = _name;
            this.role = _role;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"{name} works as {role}");
        }
    }
}
