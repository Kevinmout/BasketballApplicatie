using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class UserCollection
    {
        private List<User> users;
        public List<User> GetUsers()
        {
            return users;
        }
        public UserCollection()
        {
            users = new List<User>();
        }
    }
}
