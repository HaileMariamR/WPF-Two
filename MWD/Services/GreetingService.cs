using MWD.Models;
using System;

namespace MWD.Services
{
	internal class GreetingService
	{
		public GreetingService() { }

		public Greeting GetGreeting()
		{
			return new Greeting(string.Format("It's {0}. Oh, hello, ", DateTime.Now.ToString("HH:mm:ss")), "Steve");
		}
	}
}
