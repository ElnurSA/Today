using System;
namespace Domain.Models
{
	public class Student : BaseEntity
	{
		public object FullName { get; set; }
		public int Age { get; set; }
		public string email { get; set; }
	}
}

