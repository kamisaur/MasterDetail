using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;


namespace MasterDetail.Core.ViewModels
{
	public class WindowSecondViewModel: MvxNavigationViewModel
	{
		public int ParentNo { get; set; } = 99;
		public WindowSecondViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
		{
		}
	}
}
