using System;
namespace Domain.Models
{
	public class Studnet : BaseEntity
	{
		public string FullName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}

