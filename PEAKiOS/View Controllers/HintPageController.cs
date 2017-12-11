using System;
using UIKit;

namespace PEAKiOS.ViewControllers
{
    public class HintPageController : UIViewController
    {
        public int Index = 0;
        public UILabel hint =  new UILabel();

        public HintPageController() : base("HController", null){
            
        }

        public HintPageController(IntPtr handle) : base(handle)
        {
            
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();
            this.View.AddSubview(hint);
        }

        public void setHintText(string h){
            hint.Text = h;
        }
    }
}
