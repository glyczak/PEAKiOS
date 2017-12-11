using System;
using Foundation;
using UIKit;

namespace PEAKiOS
{
    public partial class TableSource : UITableViewSource
    {
        public string[] TableItems;
        string CellIdentifier = "TableCell";
        FirstViewController fView;
        ModuleInfoViewController mIView;

        public TableSource(string[] items, FirstViewController fView)
        {
            TableItems = items;
            this.fView = fView;
            mIView = fView.Storyboard.InstantiateViewController("ModuleInfoViewController") as ModuleInfoViewController;
        }

        public TableSource(string[] items){
            TableItems = items;

        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return TableItems.Length;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            string item = TableItems[indexPath.Row];

            //---- if there are no cells to reuse, create a new one
            if (cell == null)
            { cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); }

            cell.TextLabel.Text = item; 

            return cell;
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