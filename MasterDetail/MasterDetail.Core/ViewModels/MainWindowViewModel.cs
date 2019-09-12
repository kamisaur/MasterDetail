using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetail.Core.ViewModels
{
    public class MainWindowViewModel : MvxNavigationViewModel
    {

        public MainWindowViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            //ShowFirstViewCommand = new MvxAsyncCommand(async () => 
            //{
            //    await NavigationService.Navigate<FirstViewModel>();
            //    });

            //ShowSecondViewCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<SecondViewModel>());
        }


        //public IMvxAsyncCommand ShowFirstViewCommand { get; private set; }

        //public IMvxAsyncCommand ShowSecondViewCommand { get; private set; }
    }
}
