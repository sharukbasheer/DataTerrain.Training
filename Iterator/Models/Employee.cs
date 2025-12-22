using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Models
{
    public class Employee
    {
        public int Id { get; }
        public string Name { get; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
