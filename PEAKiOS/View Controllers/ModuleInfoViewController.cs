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
            //var imgUrl = new NSUrl("https://www.google.com/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&cad=rja&uact=8&ved=0ahUKEwifvqDb2JbYAhVESN8KHVvcBn0QjRwIBw&url=https%3A%2F%2Ffermentationwineblog.com%2F2013%2F01%2Fpinot-pork-loin-and-consumers-the-grocery-store-and-wine-debate%2F&psig=AOvVaw23tKIUpwTVfl_FRW_u3tzt&ust=1513794126366289");
            //var data = NSData.FromUrl(imgUrl);
            //UIImage img = UIImage.LoadFromData(data);
            UIImage img = new UIImage("Storefront.jpg");
            ModuleImage.Image = img;

            //UIView hTHeader = new UIView();
            UILabel headerLabel = new UILabel();
            headerLabel.Text = "Hints";
            //hTHeader.AddSubview(headerLabel);
            //hTHeader.Frame = new CoreGraphics.CGRect(100,100,50,10);
            hTable.TableHeaderView = headerLabel;
            System.Console.WriteLine(headerLabel.Text);

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