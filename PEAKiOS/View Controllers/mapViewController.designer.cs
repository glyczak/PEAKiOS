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
    [Register ("mapViewController")]
    partial class mapViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        PEAKiOS.mapViewController mapView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (mapView != null) {
                mapView.Dispose ();
                mapView = null;
            }
        }
    }
}