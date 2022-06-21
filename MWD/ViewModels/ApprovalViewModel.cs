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
	internal sealed class ApprovalViewModel : BaseViewModel
	{

		


		public List<ApprovalModel> _allApprovals;

		public List<ApprovalModel> AllApprovals
		{
			get => _allApprovals;
			set => Set(ref _allApprovals, value);
		}

		private ApprovalModel _selectedApproval;
		public ApprovalModel SelectedApproval
        {
			get => _selectedApproval;
			set => Set(ref _selectedApproval , value);

        }


		public List<ApprovalModel> GetApprovals()
		{
			AllApprovals = new List<ApprovalModel>()
			{
				new ApprovalModel()
			{
					Id = 1,
					StartTime = DateTime.Now,
					EndTime = DateTime.Now,
					Reason = "Reason 1"
				
			},
				new ApprovalModel()
			{
					Id = 2,
					StartTime = DateTime.Now,
					EndTime = DateTime.Now,
					Reason = "Reason 2"

			},
				new ApprovalModel()
			{
					Id = 3,
					StartTime = DateTime.Now,
					EndTime = DateTime.Now,
					Reason = "Reason 3"

			},
				new ApprovalModel()
			{
					Id = 4,
					StartTime = DateTime.Now,
					EndTime = DateTime.Now,
					Reason = "Reason 4"

			}
			};
			return AllApprovals;
		}

		public List<ApprovalModel> RemoveApproval(ApprovalModel app)
		{
			AllApprovals.Remove(app);
			return AllApprovals;
		}



		public LambdaCommand deleteConfirmation { get; set; }


		public ApprovalViewModel()
		{
			GetApprovals();
			deleteConfirmation = new LambdaCommand((o) => true, (o) => {
				var x = RemoveApproval(SelectedApproval);
				AllApprovals = new List<ApprovalModel>(x);
			});
		}
	}
}