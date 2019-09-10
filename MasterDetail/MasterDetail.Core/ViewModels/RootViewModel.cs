using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetail.Core.ViewModels
{

	public class RootViewModel : MvxNavigationViewModel
	{
		public string Title { get; set; } = "Root ViewModel";

		public int Count { get; set; }

		public RootViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IMvxViewModelLoader mvxViewModelLoader) : base(logProvider, navigationService)
		{

	
		}

		public IMvxAsyncCommand<int> ShowWindowChildCommand { get; private set; }


	}
}
