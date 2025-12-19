using BuilderMethod.Interface;
using BuilderMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMethod.Builder
{
    public class UserBuilder : IUserBuilder
    {
        private readonly User user = new User();

        public IUserBuilder SetEmail(string email)
        {
            user.Email = email;
            return this;
        }

        public IUserBuilder Setid(int id)
        {
            user.Id = id;
            return this;
        }

        public IUserBuilder SetName(string name)
        {
            user.Name = name;
            return this;
        }

        public IUserBuilder SetPhone(long phone)
        {
            user.Phone = phone;
            return this;
        }

        public IUserBuilder SetRole(string role)
        {
            user.Role = role;
            return this;
        }
        public User Build()
        {
            return user;
        }

    }
}
