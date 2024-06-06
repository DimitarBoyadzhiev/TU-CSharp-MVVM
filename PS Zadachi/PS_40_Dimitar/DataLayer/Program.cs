using DataLayer.Database;
using DataLayer.Model;
using System.Xml.Linq;
using Welcome.Model;
using Welcome.Others;

namespace DataLayer
{
	internal class Program
	{
		static void Main(string[] args)
		{
			using (var context = new DatabaseContext())
			{
				context.Database.EnsureCreated();
				context.Add<DatabaseUser>(new DatabaseUser()
				{
					Name = "user",
					Password = "password",
					Email = "sjrhgkusjglshgk",
					FakNomer = "12543576352",
					Expires = DateTime.Now,
					Role = UserRolesEnum.STUDENT
				});

				context.SaveChanges();
				var users = context.Users.ToList();

				string nameToCheck = Console.ReadLine();
				string passToCheck = Console.ReadLine();

				var ret = (from user in users
						   where user.Name == nameToCheck && user.Password == passToCheck
						   select user).FirstOrDefault();

				if (ret != null)
				{
					Console.WriteLine("Validen potrebitel");
				}
				else
				{
					Console.WriteLine("Nevaliden user");
				}
			}
		}
	}
}
