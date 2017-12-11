using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace PEAKiOS.ViewControllers
{
    public class HintPagesController : UIPageViewController
    {
        public HintPagesController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            System.Console.WriteLine("View Loaded");
        }

    }
}
