using BasketbalDAL;
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

        public void UsersDal()
        {
            BasketbalDAL.UsersDal DAL = new BasketbalDAL.UsersDal();
            foreach (UserDal userDal in DAL.GetUsers())
            {
                users.Add(new User(
                    userDal.Username,
                    userDal.Password));
            }
        }
    }
}
