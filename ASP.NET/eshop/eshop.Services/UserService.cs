using eshop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Services
{
    public class UserService : IUserService
    {

        private List<User> _users = new List<User>()
        {
             new(){ Id=1, Email="a@test.com", Name="türkay", Password="123456", Role="admin", UserName="turko"},
             new(){ Id=2, Email="b@test.com", Name="Nisa", Password="123456", Role="editor", UserName="nisa"},
             new(){ Id=3, Email="c@test.com", Name="Muammer", Password="123456", Role="client", UserName="muammer"},

        };
        public User ValidateUser(string userName, string password)
        {
            return _users.SingleOrDefault(u => u.UserName == userName && u.Password == password);
        }

    }
}
