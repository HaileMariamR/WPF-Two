namespace MWD.Models
{
	internal class Greeting
	{
		public string Name { get; set; }
		public string GreetingText { get; set; }

		public Greeting(string greetingText, string name)
		{
			GreetingText = greetingText;
			Name = name;
		}

		public override string ToString()
		{
			return string.Format("{0} {1}", GreetingText, Name);
		}
	}
}
