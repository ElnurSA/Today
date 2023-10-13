using System;
using TodayLesson.Controllers;

namespace Domain.Models
{
	public class Eagle : Bird
	{
        public override void Sound()
        {
            Console.WriteLine("Eagle sound");
        }
    }
}

