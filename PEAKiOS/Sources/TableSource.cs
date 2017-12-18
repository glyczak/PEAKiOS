using System;
using System.Linq;
using Foundation;
using UIKit;
using PEAKiOS.Models;
using System.Collections.Generic;

namespace PEAKiOS
{
    public partial class TableSource : UITableViewSource
    {
        public List<PEAKiOS.Models.Module> TableItems, SearchItems;
        private List<PEAKiOS.Models.Module> modules;
        string CellIdentifier = "TableCell";
        FirstViewController fView;
        ModuleInfoViewController mIView;

        public TableSource(List<PEAKiOS.Models.Module> mods, FirstViewController fView)
        {
            modules = mods;
            TableItems = mods;
            SearchItems = mods;
            this.fView = fView;
            mIView = fView.Storyboard.InstantiateViewController("ModuleInfoViewController") as ModuleInfoViewController;
        }

        public TableSource(List<PEAKiOS.Models.Module> mods){
            //TableItems = mods.Select(x => x.Name).ToList();
            //SearchItems = mods.Select(x => x.Name).ToList();
            TableItems = mods;
            SearchItems = mods;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return SearchItems.Count();
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            string item = SearchItems[indexPath.Row].Name;

            //if there are no cells to reuse, create a new one
            if (cell == null) { 
                cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); 
            }

            cell.TextLabel.Text = SearchItems[indexPath.Row].Name; 

            return cell;
        }

        public void PerformSearch(string searchText){
            searchText = searchText.ToLower();
            this.SearchItems = TableItems.Where(i => i.Name.ToLower().Contains(searchText)).ToList();
            //System.Console.WriteLine(this.SearchItems);

        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            tableView.DeselectRow(indexPath, true);

            if (fView != null)
            {
                if (SearchItems.Count() == TableItems.Count())
                {
                    fView.SetSelected(indexPath.Row);
                }
                else{
                    PEAKiOS.Models.Module selected = SearchItems[indexPath.Row];
                    int cRow = 0;
                    for (int i = 0; i < TableItems.Count; i++)
                    {
                        if(TableItems[i].Equals(selected)){
                            cRow = i;
                            break;
                        }
                    }
                    fView.SetSelected(cRow);
                }
                fView.PerformSegue("toModuleInfo", this);
            }
        }
    }
}