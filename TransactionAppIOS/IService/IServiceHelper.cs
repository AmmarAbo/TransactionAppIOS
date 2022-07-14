using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionAppIOS.Model;

namespace TransactionAppIOS.IService
{
    public interface IServiceHelper
    {
        Task<List<TransactionItem>> GetTransactions();
        Task<TransactionItem> GetTransactionDetails(string TransactionId);
    }
}