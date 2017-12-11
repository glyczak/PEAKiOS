using System;
using Foundation;
using UIKit;

namespace PEAKiOS
{
    public partial class HintTableSource : UITableViewSource
    {
        public string[] TableItems;
        string CellIdentifier = "TableCell";
        ModuleInfoViewController mView;
        //HintPagesController pView;

        public HintTableSource(string[] items, ModuleInfoViewController mView)
        {
            TableItems = items;
            this.mView = mView;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return TableItems.Length;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            string item = TableItems[indexPath.Row];

            //if there are no cells to reuse, create a new one
            if (cell == null)
            { cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); }

            cell.TextLabel.Text = item;
            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            tableView.DeselectRow(indexPath, true);
            if (mView != null)
            {
                mView.SetSelected(indexPath.Row);
                mView.PerformSegue("showHints", this);
                //System.Console.WriteLine("Segue is performing");
            }
        }
    }
}