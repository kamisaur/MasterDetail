using MasterDetail.Core.ViewModels;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Presenters;
using MvvmCross.Presenters.Attributes;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MasterDetail.Wpf.Views
{
	/// <summary>
	/// Interaction logic for WindowView.xaml
	/// </summary>
	public partial class WindowView : IMvxOverridePresentationAttribute
	{
		public WindowView()
		{
			InitializeComponent();
		}

		public MvxBasePresentationAttribute PresentationAttribute(MvxViewModelRequest request)
		{
			var instanceRequest = request as MvxViewModelInstanceRequest;
			var viewModel = instanceRequest?.ViewModelInstance as WindowViewModel;

			return new MvxWindowPresentationAttribute
			{
				Identifier = $"{nameof(WindowView)}.{viewModel?.Count}"
			};
		}




		//public MvxBasePresentationAttribute PresentationAttribute(MvxViewModelRequest request)
		//{
		//	var instanceRequest = request as MvxViewModelInstanceRequest;
		//	var viewModel = instanceRequest?.ViewModelInstance as WindowChildViewModel;

		//	return new MvxContentPresentationAttribute
		//	{
		//		//WindowIdentifier = $"{nameof(MainWindow)}.{viewModel?.ParentNo}",
		//		WindowIdentifier = $"{nameof(MainWindow)}.{viewModel?.ParentNo}",
		//		//StackNavigation = false
		//	};
		//}



	}
}
