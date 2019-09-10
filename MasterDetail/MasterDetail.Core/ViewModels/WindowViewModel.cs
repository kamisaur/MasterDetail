using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvvmCross.Commands;
using MvvmCross.Logging;


namespace MasterDetail.Core.ViewModels
{

	public class WindowChildParam
	{
		public int ParentNo { get; set; }
		public int ChildNo { get; set; }
	}

	public class WindowViewModel : MvxNavigationViewModel
	{

		private static int _count;

		public string Title => $"No.{Count} Window View";

		public int Count { get; set; }




		public WindowViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
		{
			_count++;
			Count = _count;

			ShowWindowChildCommand = new MvxAsyncCommand<int>(async no =>
			{
				await NavigationService.Navigate<WindowChildViewModel, WindowChildParam>(new WindowChildParam
				{
					ParentNo = Count,
					ChildNo = no
				});
			});

			ShowSecondChildCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<WindowSecondViewModel>());
			CloseCommand = new MvxAsyncCommand(async () => await NavigationService.Close(this));
		}


		public IMvxAsyncCommand<int> ShowWindowChildCommand { get; private set; }

		public IMvxAsyncCommand ShowSecondChildCommand { get; private set; }

		public IMvxAsyncCommand CloseCommand { get; private set; }

	}
}
