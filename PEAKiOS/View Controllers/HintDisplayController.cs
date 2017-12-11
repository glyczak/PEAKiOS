using Foundation;
using System;
using UIKit;
using PEAKiOS.Sources;

namespace PEAKiOS
{
    public partial class HintDisplayController : UITableViewController
    {

        UITableView HTable;
        string[] exHints;
        int hintType;
        public HintDisplayController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            HTable = base.TableView;

            switch (hintType){
                case 0:
                    exHints = new string[] { "example prevention hint number one", "example prevention hint number two", "example prevention hint number three" };
                    break;
                case 1:
                    exHints = new string[] { "example instruction hint number one", "example instruction hint number two", "example instruction hint number three" };
                    break;
                case 2:
                    exHints = new string[] { "example response hint number one", "example response hint number two", "example response hint number three" };
                    break;
                default:
                    exHints = new string[] { "FAILED", "FAILED", "FAILED" };
                    break;
            }

            HTable.Source = new HintsSource(exHints, this);

        }

        public void setHintType(int hintType){
            this.hintType = hintType;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}