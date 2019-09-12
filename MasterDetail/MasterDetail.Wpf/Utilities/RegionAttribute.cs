using MvvmCross.Presenters.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail.Wpf.Utilities
{
    class RegionAttribute : MvxBasePresentationAttribute
    {
        public Region Region { get; private set; }

        public RegionAttribute(Region region)
        {
            Region = region;
        }
    }
}
