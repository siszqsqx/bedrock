﻿using System.Windows.Forms;
using Bedrock.Regions;
using Bedrock.Views;
using Microsoft.Practices.ServiceLocation;

namespace Bedrock.Winform
{
    public partial class PartialView : UserControl, IView
    {
        public PartialView()
        {
            InitializeComponent();
        }

        public object DataContext { get; set; }

        public void RegisterRegion(string regionName, object control)
        {
            var instance = ServiceLocator.Current.GetInstance<IRegionManager>();
            if (instance != null)
            {
                instance.Regions.Add(new Region(regionName, control));
            }
        }
    }
}
