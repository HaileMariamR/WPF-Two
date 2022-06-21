using MWD.Commands;
using MWD.Models;
using MWD.Services;
using MWD.Views;

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

		


		public LambdaCommand GotoAPproval { get; set; }
		public LambdaCommand GotoNotification { get; set; }
		public LambdaCommand GotoMetting { get; set; }


		public MainWindowViewModel()
		{
			GotoNotification = new LambdaCommand((o) => true, (o) => {
				Notification notification = new Notification();
				notification.Show();
			});

			GotoMetting = new LambdaCommand((o) => true, (o) => {
				Meeting meeting = new Meeting();
				meeting.Show();
			});
			GotoAPproval = new LambdaCommand((o) => true, (o) => {
				Approval approval = new Approval();
				approval.Show();
			});

		}
	}
}