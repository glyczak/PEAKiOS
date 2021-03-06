﻿using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using Refit;
using UIKit;
using PEAKiOS.Sources;

namespace PEAKiOS
{
    public partial class FirstViewController : UITableViewController
    {
        UITableView table;
        UISearchBar searchBar = new UISearchBar();
        TableSource tSource;
        //List<PEAKiOS.Models.Module> modulesRes;
        //List<PEAKiOS.Models.Hint> hintsRes;
        List<PEAKiOS.Models.Module> modules;

        int rowSelected;

        protected FirstViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        /*public override async void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            //get built-in UITableView from UITableViewController
            table = base.TableView;

            var api = RestService.For<IPEAKApi>("http://0bd87470.ngrok.io");
            modulesRes = await api.GetModules();
            hintsRes = await api.GetModuleHints(1);
            //System.Console.WriteLine(hintsRes[0].Content);

            List<PEAKiOS.Models.Hint> preventionHints = new List<Models.Hint>();
            List<PEAKiOS.Models.Hint> instructionHints = new List<Models.Hint>();
            List<PEAKiOS.Models.Hint> responseHints = new List<Models.Hint>();

            foreach (PEAKiOS.Models.Hint hint in hintsRes){
                switch(hint.CategoryId){
                    case 0:
                        preventionHints.Add(hint);
                        break;
                    case 2:
                        instructionHints.Add(hint);
                        break;
                    case 3:
                        responseHints.Add(hint);
                        break;
                    default:
                        break;
                }
            }
            //System.Console.WriteLine(preventionHints[0].Content);
            //array to populate table cells
            string[] modules = modulesRes.Select(x => x.Name).ToArray();
            //string[] modules = { "First Module", "Second Module", "Third Module", "Fourth Module" };
            table.Source = new TableSource(modules, this);
        }*/

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            //get built-in UITableView from UITableViewController
            table = base.TableView;
            List<string> preventionHints = new List<string>(new string[] { "Prevention Hint Number One", "Prevention Hint Number Two" });
            List<string> instructionHints = new List<string>(new string[] { "Instruction Hint Number One", "Instruction Hint Number Two" });
            List<string> responseHints = new List<string>(new string[] { "Response Hint Number One", "Response Hint Number Two" });

            //System.Console.WriteLine(preventionHints[0].Content);
            //array to populate table cells
            PEAKiOS.Models.Module m1 = new PEAKiOS.Models.Module();
            m1.Name = "First Module";
            PEAKiOS.Models.Module m2 = new PEAKiOS.Models.Module();
            m2.Name = "Second Module";
            PEAKiOS.Models.Module m3 = new PEAKiOS.Models.Module();
            m3.Name = "Third Module";
            PEAKiOS.Models.Module m4 = new PEAKiOS.Models.Module();
            m4.Name = "Fourth Module";
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            modules = new List<PEAKiOS.Models.Module> { m1, m2, m3, m4 };
=======
            modules = new List<PEAKiOS.Models.Module> {m1,m2,m3,m4};
>>>>>>> parent of c797493... Broke many things
=======
            modules = new List<PEAKiOS.Models.Module> {m1,m2,m3,m4};
>>>>>>> parent of c797493... Broke many things
=======
            modules = new List<PEAKiOS.Models.Module> {m1,m2,m3,m4};
>>>>>>> parent of c797493... Broke many things
            tSource = new TableSource(modules, this);
            table.Source = tSource;

            searchBar = new UISearchBar();
            searchBar.SizeToFit();
            searchBar.AutocorrectionType = (UIKit.UITextAutocorrectionType)UITextAutocapitalizationType.None;
            searchBar.AutocapitalizationType = UITextAutocapitalizationType.None;

<<<<<<< HEAD
            searchBar.TextChanged += (sender, e) =>
            {
                //method called when user searches  
                searchTable();
            };
=======
            searchBar.TextChanged += (sender, e) =>  
            {  
                //this is the method that is called when the user searches  
                searchTable();  
            };  
>>>>>>> parent of c797493... Broke many things

            table.TableHeaderView = searchBar;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public void SetSelected(int s)
        {
            rowSelected = s;
        }

        public void searchTable()
        {
            //perform the search, and refresh the table with the results  
            tSource.PerformSearch(searchBar.Text);
            table.ReloadData();
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            if (segue.Identifier == "toModuleInfo")
            {
                var moduleController = segue.DestinationViewController as ModuleInfoViewController;
                //moduleController.label.Text = table.Source.TitleForHeader(table, 0);
                if (moduleController != null)
                {
                    //moduleController.SetTitleText(modulesRes[rowSelected].Name);
                    //moduleController.SetDescText(modulesRes[rowSelected].Description);
                    moduleController.SetTitleText(modules[rowSelected].Name);
                    moduleController.SetDescText("Description of Module");
                }
            }
            else if (segue.Identifier == "toMapView")
            {
                var mapController = segue.DestinationViewController as mapViewController;
=======
>>>>>>> parent of c797493... Broke many things
=======
>>>>>>> parent of c797493... Broke many things
=======
>>>>>>> parent of c797493... Broke many things

            var moduleController = segue.DestinationViewController as ModuleInfoViewController;
            //moduleController.label.Text = table.Source.TitleForHeader(table, 0);
            if (moduleController != null)
            {
                //moduleController.SetTitleText(modulesRes[rowSelected].Name);
                //moduleController.SetDescText(modulesRes[rowSelected].Description);
                moduleController.SetTitleText(modules[rowSelected].Name);
                moduleController.SetDescText("Description of Module");
            }
        }
    }
}