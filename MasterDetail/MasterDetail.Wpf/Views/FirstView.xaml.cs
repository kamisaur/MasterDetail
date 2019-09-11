using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
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
	/// Interaction logic for FirstView.xaml
	/// </summary>
	[MvxContentPresentation(WindowIdentifier = nameof(MainWindow), StackNavigation = false)]
	public partial class FirstView
	{
		public FirstView()
		{
			InitializeComponent();
		}
	}
}
