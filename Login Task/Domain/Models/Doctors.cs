using System;
namespace Domain.Models
{
	public class Doctors : BaseEntity
	{
		public string FullName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

