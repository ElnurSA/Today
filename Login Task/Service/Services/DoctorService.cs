using System;
using Domain.Models;

namespace Service.Services
{
	public class DoctorService
	{
		public Doctors GeAllDoctors()
		{
			Doctors doctor = new()
			{
				id = 1,
				FullName = "Elnur Safiyev",
				Email = "elnur@gmail.com",
				Password = "Elnur123",
				Age = 19

			};

			

			return doctor;
		}

		

	}
}


