using WelcomeExtended.Others;
using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;
using Welcome.Others;
using static WelcomeExtended.Others.Delegates;
using WelcomeExtended.Data;

namespace WelcomeExtended
{
	public class Program
	{
		static void Main(string[] args)
		{

			try
			{
				//var user = new User
				//{
				//	Name = "John Smith",
				//	Password = "password123",
				//	Role = UserRolesEnum.STUDENT,
				//};

				//var viewModel = new UserViewModel(user);

				//var view = new UserView(viewModel);

				//view.Display();

				////throw error here
				//view.DisplayError();

				UserData userData = new UserData();

				User studentUser = new User()
				{
					Name = "student",
					Password = "123",
					Role = UserRolesEnum.STUDENT,
				};
				User student2User = new User()
				{
					Name = "student2",
					Password = "123",
					Role = UserRolesEnum.STUDENT,
				};
				User teacherUser = new User()
				{
					Name = "Teacher",
					Password = "1234",
					Role = UserRolesEnum.PROFESSOR,
				};

				userData.AddUser(studentUser);
				userData.AddUser(student2User);
				userData.AddUser(teacherUser);
			}
			catch (Exception e)
			{
				var log = new ActionOnError(Log);
				log(e.Message);
			}
			finally
			{
                Console.WriteLine("Executed in any case!");
            }
		}
	}
}
