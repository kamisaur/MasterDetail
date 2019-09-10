using MasterDetail.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetail.Core
{
    public class App : MvxApplication
	{
		public override void Initialize()
		{
			CreatableTypes()
				.EndingWith("Service")
				.AsInterfaces()
				.RegisterAsLazySingleton();


			//RegisterAppStart<RootViewModel>();
			RegisterAppStart<WindowViewModel>();
		}

	}
}
