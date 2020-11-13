using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDal
    {
        public string Username { get;}
        public string Password { get;}
        public UserDal(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
