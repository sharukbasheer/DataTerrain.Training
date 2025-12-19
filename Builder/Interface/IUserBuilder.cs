using BuilderMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMethod.Interface
{
    public interface IUserBuilder
    {
        IUserBuilder Setid(int id);
        IUserBuilder SetName(string name);
        IUserBuilder SetEmail(string email);
        IUserBuilder SetRole(string role);
        IUserBuilder SetPhone(long phone);
        User Build();
    }
}
