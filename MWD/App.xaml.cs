using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MWD.Services;
using MWD.ViewModels;
using System.Windows;
using WPF_MVVM_Core_with_DI.Views;

namespace WPF_MVVM_Core_with_DI
{
	public partial class App : Application
	{
		private readonly IHost _host;
		public App()
		{
			_host = Host.CreateDefaultBuilder()
				.ConfigureServices((context, services) =>
				{
					ConfigureServices(services);
				})
				.Build();
		}

		private void ConfigureServices(IServiceCollection services)
		{
			services.AddSingleton<MainWindow>();
			services.AddTransient<GreetingService>();
			services.AddTransient<MainWindowViewModel>();
		}

		protected async override void OnStartup(StartupEventArgs e)
		{
			await _host.StartAsync();

			var mainWindow = _host.Services.GetRequiredService<MainWindow>();
			mainWindow.DataContext = _host.Services.GetService<MainWindowViewModel>();
			mainWindow.Show();

			base.OnStartup(e);
		}

		protected async override void OnExit(ExitEventArgs e)
		{
			await _host.StopAsync();

			base.OnExit(e);
		}
	}
}
