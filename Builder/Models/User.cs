using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMethod.Models
{
    public class User
    {
        public int Id { get;  set; }
        public string Name { get;  set; }
        public string Email { get;  set; }
        public long Phone { get;  set; }
        public string Role { get;  set; }

        public override string ToString()
        {
            return $" User Id: {Id}. Name: {Name}, Emai: {Email},Phone: {Phone},Role: {Role}";
        }
    }
}
