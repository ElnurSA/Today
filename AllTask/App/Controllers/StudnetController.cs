using System;
using Service.Services;

namespace App.Controllers
{
	public class StudnetController
	{
		private readonly StudentService _studentService;

        public StudnetController()
        {
            _studentService = new StudentService();
        }

        public void GetAllStudents()
		{
			foreach (var item in _studentService.GetAllStudents())
			{
                string result = $"{item.FullName} - {item.Age} - {item.email}";

				Console.WriteLine(result);
            }
		}

        public void GetStudentById()
        {
            var student = _studentService.GetById(3);
            string result = $"{student.FullName} - {student.Age} - {student.email}";

            Console.WriteLine(result);
        }

        public void AvarageOfStudentAges()
        {
            var students = _studentService.GetAllStudents();
            var sumAge = students.Sum(m => m.Age);
            Console.WriteLine(sumAge / students.Length);
        }

        public void SortByStudentAge()
        {
            var studnets = _studentService.GetAllStudents();
            
        }

    }
}

