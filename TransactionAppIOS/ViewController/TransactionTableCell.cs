using System;
using Foundation;
using TransactionAppIOS.Model;
using UIKit;

namespace TransactionAppIOS.ViewController
{
    public class TransactionTableCell: UITableViewCell
    {
        public TransactionTableCell()
        {
        }
        public void updateCell(TransactionItem transactionItem) {

            //Here for update by the nanme
            transactionAmmount.Text = transactionItem.paidAmount;
                transactionNane.Text = transactionItem.name;
            bankName.Text = transactionItem.bankName;
            transactionDate.Text = transactionItem.createdAt;
            instantTransaction.Text = transactionItem.transfertType;

        }
    }
}
