using System;

using UIKit;

namespace PEAKiOS
{
    public partial class FirstViewController : UITableViewController
    {
        protected FirstViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            //get built-in UITableView from UITableViewController
            UITableView table = base.TableView;

            //array to populate table cells
            string[] modules = { "Grocery Store", "Playground", "Movie Theater", "Doctors Office", "Library" };
            table.Source = new TableSource(modules, this);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}