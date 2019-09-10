﻿using System;
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
using MasterDetail.Core.ViewModels;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Presenters;
using MvvmCross.Presenters.Attributes;
using MvvmCross.ViewModels;

namespace MasterDetail.Wpf.Views
{
	/// <summary>
	/// Interaction logic for WindowSecondView.xaml
	/// </summary>
	public partial class WindowSecondView : IMvxOverridePresentationAttribute
	{
		public WindowSecondView()
		{
			InitializeComponent();
		}

		public MvxBasePresentationAttribute PresentationAttribute(MvxViewModelRequest request)
		{
			var instanceRequest = request as MvxViewModelInstanceRequest;
			var viewModel = instanceRequest?.ViewModelInstance as WindowSecondViewModel;

			return new MvxContentPresentationAttribute
			{
				WindowIdentifier = $"{nameof(WindowView)}.{viewModel?.ParentNo}",
				StackNavigation = false
			};
		}
	}
}
