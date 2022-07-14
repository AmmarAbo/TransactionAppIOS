using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransactionAppIOS.Model;
using UIKit;

namespace TransactionAppIOS.ViewController
{
	public class RootTableSource : UITableViewSource
	{
		// there is NO database or storage of Tasks in this example, just an in-memory List<>
		TransactionItem[] tableItems;
		string cellIdentifier = "taskcell"; // set in the Storyboard

		public RootTableSource(TransactionItem[] items)
		{
			tableItems = items;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return tableItems.Length;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			// in a Storyboard, Dequeue will ALWAYS return a cell, 
			var cell = tableView.DequeueReusableCell(cellIdentifier);
			// now set the properties as normal
			cell.TextLabel.Text = tableItems[indexPath.Row].name;
			if (tableItems[indexPath.Row].status)
				cell.Accessory = UITableViewCellAccessory.Checkmark;
			else
				cell.Accessory = UITableViewCellAccessory.None;
			return cell;
		}
		public TransactionItem GetItem(int id)
		{
			return tableItems[id];
		}
	}
}
