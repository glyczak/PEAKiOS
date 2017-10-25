using System;
using Foundation;
using UIKit;

namespace PEAKiOS
{
    public partial class TableSource : UITableViewSource
    {
        string[] TableItems;
        string CellIdentifier = "TableCell";
        FirstViewController fView;

        public TableSource(string[] items, FirstViewController fView)
        {
            TableItems = items;
            this.fView = fView;
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
            UIAlertController okAlertController = UIAlertController.Create("Row Selected", TableItems[indexPath.Row], UIAlertControllerStyle.Alert);
            okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

            tableView.DeselectRow(indexPath, true);
            fView.PresentViewController(okAlertController, true, null);
        }
    }
}