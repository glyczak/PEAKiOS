// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PEAKiOS
{
    [Register ("ModuleInfoViewController")]
    partial class ModuleInfoViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView hintTable { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelOne { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ModuleImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UINavigationItem ModulePageNav { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (hintTable != null) {
                hintTable.Dispose ();
                hintTable = null;
            }

            if (labelOne != null) {
                labelOne.Dispose ();
                labelOne = null;
            }

            if (ModuleImage != null) {
                ModuleImage.Dispose ();
                ModuleImage = null;
            }

            if (ModulePageNav != null) {
                ModulePageNav.Dispose ();
                ModulePageNav = null;
            }
        }
    }
}