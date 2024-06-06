using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;

namespace Welcome.ViewModel
{
	public class UserViewModel
	{
		private User _user;


		public UserViewModel(User user)
		{
			_user = user;
		}

		public UserRolesEnum Role
		{
			get { return _user.Role; }
			set { _user.Role = value; }
		}

		public string Password
		{
			get { return _user.Password;}
			set 
			{
				_user.Password = value;
			}
		}


		public string Name
		{
			get { return _user.Name; }
			set { _user.Name = value; }
		}

		public string Email
		{
			get { return _user.Email; }
			set { _user.Email = value; }
		}

		public string FakNomer
		{
			get { return _user.FakNomer; }
			set { _user.FakNomer = value; }
		}
	}
}
