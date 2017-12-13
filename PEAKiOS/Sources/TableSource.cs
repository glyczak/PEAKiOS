using System;
using System.Linq;
using Foundation;
using UIKit;


namespace PEAKiOS
{
    public partial class TableSource : UITableViewSource
    {
        public string[] TableItems, SearchItems;
        string CellIdentifier = "TableCell";
        FirstViewController fView;
        ModuleInfoViewController mIView;

        public TableSource(string[] items, FirstViewController fView)
        {
            TableItems = items;
            SearchItems = items;
            this.fView = fView;
            mIView = fView.Storyboard.InstantiateViewController("ModuleInfoViewController") as ModuleInfoViewController;
        }

        public TableSource(string[] items){
            TableItems = items;
            SearchItems = items;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return SearchItems.Length;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            System.Console.WriteLine(indexPath.Row);
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            string item = SearchItems[indexPath.Row];

            //if there are no cells to reuse, create a new one
            if (cell == null) { 
                cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); 
            }

            cell.TextLabel.Text = SearchItems[indexPath.Row]; 

            return cell;
        }

        public void PerformSearch(string searchText){
            searchText = searchText.ToLower();
            this.SearchItems = TableItems.Where(i => i.ToLower().Contains(searchText)).ToArray();
            //System.Console.WriteLine(this.SearchItems);

        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            tableView.DeselectRow(indexPath, true);
            if (fView != null)
            {
                fView.SetSelected(indexPath.Row);
                fView.PerformSegue("toModuleInfo", this);
            }
        }
    }
}