using System;
using Service.Services;

namespace Login.Controllers
{
	public class DoctorController
	{

		private readonly DoctorService _doctorService;

		public DoctorController()
		{
			_doctorService = new DoctorService();
		}




		public void LoginCheck()
		{

			var info = _doctorService.GeAllDoctors();

			string password = info.Password;

			string email = info.Email;

			Console.WriteLine("Please enter your email: ");

			string emailCheck = Console.ReadLine();

			Console.WriteLine("Please enter you password: ");

			string passwordCheck = Console.ReadLine();

			if(passwordCheck == password && emailCheck == email)
			{
				Console.WriteLine("Access granted");
			}
			else
			{
				Console.WriteLine("Email or password is wrong");
				
			}


		}
	}
}

