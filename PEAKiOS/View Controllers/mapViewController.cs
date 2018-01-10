using Foundation;
using System;
using UIKit;

namespace PEAKiOS
{
    public partial class mapViewController : UIViewController
    {
        public mapViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}