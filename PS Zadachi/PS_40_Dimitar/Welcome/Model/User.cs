using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
	public class User
	{
		private string name;

		private string password;

		private UserRolesEnum role;

		private string fakNomer;

		private string email;

		private DateTime expires;

		public DateTime Expires
		{
			get { return expires; }
			set { expires = value; }
		}


		public virtual int Id{ get; set; }


		public UserRolesEnum Role
		{
			get { return role; }
			set { role = value; }
		}


		public string Password
		{
			get { return Decrypt(password); }
			set {
					password = Encrypt(value);
					//Console.WriteLine(password);
            }
		}


		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		

		public string FakNomer
		{
			get { return fakNomer; }
			set { fakNomer = value; }
		}

		

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		public string Encrypt(string encr)
		{
			char[] symbols = encr.ToCharArray();
			for (int i = 0; i < encr.Length; i++)
			{
				symbols[i] += (char)Utils.CRYPT_OFFSET_VALUE;
			}

			//using the new string ctor to avoid object being type System.Char[]
			string encrypted = new string(symbols);
			return encrypted;
		}
		public string Decrypt(string crp)
		{
			char[] symbols = crp.ToCharArray();
			for (int i = 0; i < crp.Length; i++)
			{
				symbols[i] -= (char)Utils.CRYPT_OFFSET_VALUE;
			}

			//using the new string ctor to avoid object being type System.Char[]
			string decrypted = new string(symbols);
			return decrypted;
		}
	}
}
