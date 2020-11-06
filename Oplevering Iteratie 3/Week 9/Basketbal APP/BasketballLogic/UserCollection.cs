using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballLogic
{
    public class UserCollection
    {
        private List<User> users { get; }
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
