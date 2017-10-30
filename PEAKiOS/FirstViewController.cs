using System;
using System.Linq;
using Foundation;
using Refit;
using UIKit;

namespace PEAKiOS
{
    public partial class FirstViewController : UITableViewController
    {
        UITableView table;


        protected FirstViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            //get built-in UITableView from UITableViewController
            table = base.TableView;

            var api = RestService.For<IPEAKApi>("http://2e927ce5.ngrok.io");
            var modulesRes = await api.GetModules();

            //array to populate table cells
            string[] modules = modulesRes.Select(x => x.Name).ToArray();
            table.Source = new TableSource(modules, this);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            var moduleController = segue.DestinationViewController as ModuleInfoViewController;
            //moduleController.label.Text = table.Source.TitleForHeader(table, 0);
            if (moduleController != null)
            {
                //moduleController.labelOne.Text = "changed";
            }
        }
    }
}