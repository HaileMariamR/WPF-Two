using MWD.Commands;
using MWD.Models;
using MWD.Services;

namespace MWD.ViewModels
{
	internal sealed class MainWindowViewModel : BaseViewModel
	{

		private string _winTitle = "MainWindow";
		private GreetingService _greetingService;
		private Greeting _greeting;

		/// <summary>Приветствие</summary>s
		public Greeting Greeting
		{
			get => _greeting;
			set => Set(ref _greeting, value);
		}

		/// <summary>Заголовок окна</summary>
		public string WinTitle
		{
			get => _winTitle;
			set => Set(ref _winTitle, value);
		}

		public LambdaCommand GetGreetingCommand { get; set; }

		public MainWindowViewModel(GreetingService greetingService)
		{
			_greetingService = greetingService;
			GetGreetingCommand = new LambdaCommand((o) => true, (o) => { Greeting = _greetingService.GetGreeting(); });
		}
	}
}