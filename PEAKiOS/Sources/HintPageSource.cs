using System;
using System.Collections.Generic;
using PEAKiOS.ViewControllers;
using UIKit;

namespace PEAKiOS.Sources
{
    public class HintPageSource : UIPageViewControllerDataSource
    {
        public List<HintPageController> pages;
        public HintPageSource(List<HintPageController> pages)
        {
            this.pages = pages;
        }

        public override UIViewController GetNextViewController(UIPageViewController pageViewController, UIViewController referenceViewController)
        {
            var currentPage = referenceViewController as HintPageController;
            if (currentPage.Index == 0)
            {
                return pages[pages.Count - 1];
            }
            else
            {
                return pages[currentPage.Index - 1];
            }
       
        }

        public override UIViewController GetPreviousViewController(UIPageViewController pageViewController, UIViewController referenceViewController)
        {
            var currentPage = referenceViewController as HintPageController;
            return pages[(currentPage.Index + 1) % pages.Count];
      
        }
    }
}