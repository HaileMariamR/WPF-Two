using MWD.Commands;
using MWD.Models;
using MWD.Services;
using MWD.Views;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System;
using System.Linq;


namespace MWD.ViewModels
{

	
	internal sealed class MeetingViewModel : BaseViewModel
	{


		public List<string> Rooms { get; set; }
		public List<string> Doctors { get; set; }
		public List<string> MeetingTimes { get; set; }



		

		private string _sectedRoom;
		private string _selectedDoctor;
		private string _selectedTime;		
		public string SelectedRoom
		{
			get => _sectedRoom;
			set => Set(ref _sectedRoom,value );
        }
		public string SelectedDoctor
		{
			get => _selectedDoctor;
			set => Set(ref _selectedDoctor ,value);
        }

		public string SelectedTime
		{
			get => _selectedTime;
			set => Set(ref _selectedTime, value);
        }

		public List<MeetingModel> _allMeetings;

		public List<MeetingModel> AllMeetings
		{
			get => _allMeetings;
			set => Set(ref _allMeetings, value);
		}


		public List<MeetingModel> GetMeetings()
		{
			AllMeetings = new List<MeetingModel>() 
			{
				new MeetingModel()
			{
				Id = 1,
			    Room ="A1",
				Doctor ="Miki Mikic",
				MeetingTime = "09 - 10"
			}
			};
			return AllMeetings;
		}

		public List<MeetingModel> AddMeeting(MeetingModel newmett)
		{
			AllMeetings.Add(newmett);
			return AllMeetings;
		}

	
		public LambdaCommand AddMetting { get; set; }


		public MeetingViewModel()
		{

			Rooms = new List<string>()
			{
				"A1",
				"A2",
				"C6",
				"D7"
			};

			Doctors = new List<string>()
			{
				"Miki Mikvic",
				"Zoran Zoravnovic",
				"Peter Petrovic",
				"Marko Markovic"
			};

			MeetingTimes = new List<string>()
			{
				"9:00 : 10:00",
				"11:00: 11:15",
				"12:20 : 12: 20",
				"1:00: 7:00"
			};

			GetMeetings();
			
			Random random = new Random();

			AddMetting = new LambdaCommand((o) => true, (o) => {

				var newMeeting = new MeetingModel()
				{
					Id = random.Next(),
					MeetingTime = SelectedTime ,
					Room = SelectedRoom ,
					Doctor = SelectedDoctor
				};
				var x = AddMeeting(newMeeting);
				AllMeetings = new List<MeetingModel>(x);

			});




		}
	}
}