using Foundation;
using System;
using UIKit;

namespace PEAKiOS
{
    public partial class HintPageController : UIViewController
    {
        public HintPageController()
        {
        }

        public HintPageController (IntPtr handle) : base (handle)
        {
        }

        public int Index { get; internal set; }

        internal void setHintText(string v)
        {
            //throw new NotImplementedException();
        }
    }
}