// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MvvmLightNavigationExtension.Sample.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Button2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Navigate { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Button2 != null) {
                Button2.Dispose ();
                Button2 = null;
            }

            if (Navigate != null) {
                Navigate.Dispose ();
                Navigate = null;
            }
        }
    }
}