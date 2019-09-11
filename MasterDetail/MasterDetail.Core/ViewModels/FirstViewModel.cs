using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MasterDetail.Core.ViewModels
{
	class FirstViewModel : MvxNavigationViewModel
	{

		public string Title { get; set; } = "First View";



		public FirstViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
		{
		}

	}
}
