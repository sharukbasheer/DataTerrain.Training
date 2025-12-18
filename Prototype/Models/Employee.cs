using Prototype.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class Employee : IPrototype<Employee>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }

        public Employee Clone()
        {
            return (Employee)this.MemberwiseClone();
        }
    }

    
}
