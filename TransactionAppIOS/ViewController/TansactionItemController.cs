
using Foundation;
using System;
using System.Collections.Generic;
using System.Drawing;
using TransactionAppIOS.Helper;
using TransactionAppIOS.Model;
using UIKit;

namespace TransactionAppIOS.ViewController
{
    public partial class TansactionItemController : UITabBarController 
    
    { 
        List<TransactionItem> transactionItems;
        public TansactionItemController(IntPtr handle) : base(handle)
    {
        transactionItems = new List<TransactionItem>();


    }
    public async override void ViewWillAppear(bool animated)
    {
        base.ViewWillAppear(animated);
        transactionItems = await ServiceHelper.Instance.GetTransactions();
        TableView.Source = new RootTableSource(transactionItems.ToArray());
    }
}