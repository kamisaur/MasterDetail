﻿using MasterDetail.Core.ViewModels;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
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
	/// Interaction logic for RootView.xaml
	/// </summary>
	//[MvxContentPresentation(WindowIdentifier = nameof(WindowView), StackNavigation = false)]
	public partial class RootView
	{
		public RootView()
		{
			InitializeComponent();
		}
	}
}
