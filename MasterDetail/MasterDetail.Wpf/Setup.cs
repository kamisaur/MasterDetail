using MasterDetail.Wpf.Utilities;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Presenters;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace MasterDetail.Wpf
{
    public class Setup: MvxWpfSetup
    {
        public Setup() : base()
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxWpfViewPresenter CreateViewPresenter(ContentControl root)
        {
            return new TabPresenter(root);
        }
    }
}
