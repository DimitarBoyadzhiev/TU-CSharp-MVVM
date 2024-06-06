using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
	public static class UserHelper
	{

		public static string ToString(this UserData user)
		{
			return user.ToString();
		}

		public static void ValidateCredentials(this UserData user, string name, string password)
		{
			if(user.ValidateUser(name, password))
			{
                Console.WriteLine("The Fields cannot be empty");
            }

			user.ValidateUser(name, password);
		}

		public static User GetUser(this UserData user, string name, string password)
		{
			User userTemp = user.GetUser(name, password);

			return userTemp;
		}
		
	}
}
