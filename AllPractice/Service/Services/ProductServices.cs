using System;
using Domain.Models;

namespace Service.Services
{
	public class ProductServices
	{
		private Product[] GetAll()
		{
			return new Product[]
			{
				new Product{id = 1, Name = "Iphone 14", Price = 3000, Color = "White", Count = 10},
                new Product{id = 2, Name = "Iphone 12", Price = 2000, Color = "Black", Count = 20},
                new Product{id = 3, Name = "Iphone 11", Price = 1000, Color = "Silver", Count = 5},
                new Product{id = 4, Name = "Iphone 15", Price = 4000, Color = "White", Count = 10}
            };
		}

		public Product[] GetAllByCount(int count)
		{
			Product[] products = GetAll();

			return products.Where(m => m.Count > count).ToArray();
		}
	}
}

