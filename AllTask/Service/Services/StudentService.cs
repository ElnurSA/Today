using System;
using Domain.Models;

namespace Service.Services
{
	public class StudentService
	{
		private Student[] GetAll()
		{
			return new Student[]
			{
                new Student{id = 1, FullName = "Tunzale Memmedova", Age = 24, email = "tunzale@gmail.com"},
                new Student{id = 2, FullName = "Metnaet Abbasova", Age = 21, email = "metanet@gmail.com"},
                new Student{id = 3, FullName = "Meryem Eliyeva", Age = 23, email = "meryem@gmail.com"},
                new Student{id = 4, FullName = "Arzu Kerimova", Age = 25, email = "arzu@gmail.com"},
			};
		}

		public Student[] GetAllStudents() => GetAll();

        public Student GetById(int id) => GetAll().FirstOrDefault(m => m.id == id);

		public Student[] SortByAge()
		{
			var students = GetAll();
			var sortedStudents = students.OrderByDescending(m => m.Age).ToArray();
			return sortedStudents;
		}

		public int AvarageStudentAge()
		{
			int sum = GetAll().Sum(m => m.Age);
			return sum / GetAll().Length;
		}
    }
}

