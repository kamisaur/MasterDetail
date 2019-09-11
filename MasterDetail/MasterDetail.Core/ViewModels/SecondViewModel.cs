using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetail.Core.ViewModels
{
	class SecondViewModel : MvxNavigationViewModel
	{

		public string Title { get; set; } = "Second View";



		public SecondViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
		{
		}

	}
}