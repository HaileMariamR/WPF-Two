using MWD.Commands;
using MWD.Models;
using MWD.Services;
using MWD.Views;
using System;
using System.Collections.Generic;


namespace MWD.ViewModels
{
	internal sealed class NotificationViewModel : BaseViewModel
	{

		private string _title;
		private string _description;

		public List<NotificationModel> _allNotification;

		public List<NotificationModel> AllNotifcations
        {
			get => _allNotification;
			set => Set(ref _allNotification, value);
        }



		public string Title { get => _title; set => Set(ref _title, value); }
		public string Description { get => _description; set => Set(ref _description, value); }

		private string _createResult;
		public LambdaCommand CreateNotification { get; set; }
		public string CreateResult
		{
			get => _createResult;
			set => Set(ref _createResult, value);
		}
		public List<NotificationModel> AddNotification( NotificationModel newNoti)
		{
			AllNotifcations.Add(newNoti);
			return AllNotifcations;
		}

		public List<NotificationModel> GetNotifications()
        {
			AllNotifcations = new List<NotificationModel>()
			{
				new NotificationModel()
			{
				Id = 1,
				NotTitle = "Default Title ",
				NotDescription = "Default Description"
			}
			};
			return AllNotifcations;
        }
		public NotificationViewModel()
		{
		   GetNotifications();

			Random random = new Random();

			CreateNotification = new LambdaCommand((o) => true, (o) => {
				var newNotifcation = new NotificationModel() {
					Id = random.Next(),
					NotTitle = Title,
					NotDescription = Description,
				};
				var x = AddNotification(newNotifcation);
				AllNotifcations = new List<NotificationModel>(x);
			});


		}





	}
}