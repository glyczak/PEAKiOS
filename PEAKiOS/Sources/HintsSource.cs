using System;
using UIKit;
using Foundation;

namespace PEAKiOS.Sources
{
    public class HintsSource : UITableViewSource
    {
        public string[] TableItems;
        string CellIdentifier = "TableCell";
        HintDisplayController hdController;

        public HintsSource(string[] items, HintDisplayController c)
        {
            TableItems = items;
            hdController = c;
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
        }
    }
}