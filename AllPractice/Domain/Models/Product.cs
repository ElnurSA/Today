using System;
namespace Domain.Models
{
	public class Product : BaseEntity
	{
		public string Name{ get; set; }
		public decimal Price { get; set; }
		public int Count { get; set; }
		public string Color { get; set; }
	}
}

