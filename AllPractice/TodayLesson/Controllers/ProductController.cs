using System;
using Service.Services;

namespace TodayLesson.Controllers
{
	internal class ProductController
	{
		private readonly ProductServices _productServices;
		public ProductController()
		{
			_productServices = new ProductServices();
		}

		public void GetAllByCount()
		{
			foreach(var item in _productServices.GetAllByCount(14))
			{
				Console.WriteLine($"{item.Name} - {item.Color}");
			}
		}
	}
}

