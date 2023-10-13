using System;
using Service.Services;

namespace TodayLesson.Controllers
{
	public class StudentController
	{
		private readonly StudentService _studentService;

		public StudentController()
		{
			_studentService = new StudentService();
		}

		public void GetAllStudents()
		{
			foreach (var item in _studentService.GetAllStudents())
			{
				string result = $"{item.FullName} - {item.Age} - {item.Email}";

				Console.WriteLine(result);
			}
		}

		public void GetStudentById()
		{
			var student = _studentService.GetById(3);
			string result = $"{student.FullName} - {student.Age} - {student.Email}";

			Console.WriteLine(result);
		}


		public void SumOfStudentsAge()
		{
			var studnets = _studentService.GetAllStudents();

			var sumAge = studnets.Sum(m => m.Age);

			Console.WriteLine(sumAge);
		}

		public void AvarageOfStudentAges()
		{
			var students = _studentService.GetAllStudents();
			var sumAge = students.Sum(m => m.Age);
			Console.WriteLine(sumAge/students.Length);
		}
	}
}

