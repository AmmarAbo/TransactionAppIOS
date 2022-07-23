using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransactionAppIOS.Model;
using UIKit;

namespace TransactionAppIOS.ViewController
{
	public class TransactionTableSource : UITableViewSource
	{
		// there is NO database or storage of Tasks in this example, just an in-memory List<>
		List<TransactionItem> transactionItems;
		string cellIdentifier = "transaction_Cell"; // set in the Storyboard

		public TransactionTableSource(List<TransactionItem> items)
		{
			transactionItems = items;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return transactionItems.Count();
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			// in a Storyboard, Dequeue will ALWAYS return a cell, 
			var cell = (TransactionTableCell)tableView.DequeueReusableCell(cellIdentifier);
			TransactionItem transactionItem = transactionItems[indexPath.Row];
			// now set the properties as normal
			cell.updateCell(transactionItem);
			return cell;
		}
		public TransactionItem GetItem(int id)
		{
			return transactionItems[id];
		}
	}
}
