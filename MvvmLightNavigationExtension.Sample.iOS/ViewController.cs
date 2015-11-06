﻿using GalaSoft.MvvmLight.Views;
using MvvmLightNavigationExtension.Sample.ViewModels;
using System;
using GalaSoft.MvvmLight.Helpers;

using UIKit;

namespace MvvmLightNavigationExtension.Sample.iOS
{
    public partial class ViewController : ControllerBase
    {
        public MainViewModel ViewModel { get; private set; }

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ViewModel = new MainViewModel();

            Navigate.SetCommand("TouchUpInside", ViewModel.Goto);

            Navigate.TouchUpInside += Navigate_TouchUpInside;
        }

        private void Navigate_TouchUpInside(object sender, EventArgs e)
        {
            
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}