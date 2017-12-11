using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace PEAKiOS
{
    public partial class ModuleInfoViewController : UIViewController
    {
        string tText;
        string desc;
        UITableView hTable;
        int rowSelected;
        public UIPageViewController pageViewController;

        public ModuleInfoViewController (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();
            ModulePageNav.Title = tText;
            labelOne.Text = desc;
            hTable = hintTable;

            UIView hTHeader = new UIView();
            UILabel headerLabel = new UILabel();
            headerLabel.Text = "Hints";
            hTHeader.AddSubview(headerLabel);
            //hTHeader.Frame = new CoreGraphics.CGRect(100,100,50,10);
            hTable.TableHeaderView = hTHeader;
            System.Console.WriteLine(hTable.TableHeaderView);

            String[] cats = {"Prevention", "Instruction", "Response" };
            hTable.Source = new HintTableSource(cats, this);
        }

        public void SetSelected(int s)
        {
            rowSelected = s;
        }

        public void SetTitleText(String str) {
                tText = str;
        }

        public void SetDescText(String s){
            desc = s;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            var hintController = segue.DestinationViewController as HintDisplayController;
            if (hintController != null)
            {
                hintController.setHintType(rowSelected);
            }
        }

    }
}