using System;
namespace TodayLesson.Controllers
{
	public abstract class Animal
	{
		public string Name { get; set; }

		public abstract void Sound();
	}
}

