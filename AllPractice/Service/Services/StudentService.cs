using System;
using Domain.Models;

namespace Service.Services
{
	public class StudentService
	{
		private Studnet[] GetAll()
		{
			return new Studnet[]
			{
				new Studnet{id = 1, FullName = "Tunzale Memmedova", Age = 24, Email = "tunzale@gmail.com"},
                new Studnet{id = 2, FullName = "Metnaet Abbasova", Age = 21, Email = "metanet@gmail.com"},
                new Studnet{id = 3, FullName = "Meryem Eliyeva", Age = 23, Email = "meryem@gmail.com"},
                new Studnet{id = 4, FullName = "Arzu Kerimova", Age = 25, Email = "arzu@gmail.com"},
            };
		}

		public Studnet[] GetAllStudents() => GetAll();
		//{
		//	return GetAll();
		//}

		public Studnet GetById(int id) => GetAll().FirstOrDefault(m => m.id == id);
		//{
		//	return GetAll().FirstOrDefault(m => m.id == id);


		public int SumOfAge()
		{
			return GetAll().Sum(m => m.Age);
		}
	}
}

