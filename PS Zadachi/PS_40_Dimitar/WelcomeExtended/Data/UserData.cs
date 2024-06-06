using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using System.Linq;
using Welcome.Others;

namespace WelcomeExtended.Data
{
	public class UserData
	{
		private List<User> users;
		private int nextid;

        public UserData()
        {
            nextid = 0;
            users = new List<User>();
        }

        public void AddUser(User user)
        {
            user.Id = nextid++;
            users.Add(user);
        }

        public void DeleteUser(User user)
        {
            users.Remove(user);
        }

        public bool ValidateUser(string name, string password)
        {
            foreach (var user in users)
            {
                if (user.Name == name && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidateUserLambda(string name, string password)
        {
            return users.Where(x => x.Name == name && x.Password == password)
                .FirstOrDefault() != null ? true : false;
        }

        public bool ValidateUserLinq(string name, string password)
        {
            var ret = from user in users
                      where user.Name == name && user.Password == password
                      select user.Id;

            return ret != null ? true : false;
        }

        public User GetUser(string name, string password)
        {
            var ret = (from user in users
                      where user.Name == name && user.Password == password
                      select user).FirstOrDefault();

            return (User)ret;
        }

        public void SetActive(string name, DateTime date)
        {
			User ret = (User)(from user in users
					  where user.Name == name
							  select user).FirstOrDefault();

            ret.Expires = date;
		}

        public void AssignUserRole(string name, UserRolesEnum role)
        {
			User ret = (User)(from user in users
							  where user.Name == name
							  select user).FirstOrDefault();

            ret.Role = role;
		}
    }
}
