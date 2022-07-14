
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TransactionAppIOS.IService;
using TransactionAppIOS.Model;
using TransactionAppIOS.RemoteService;

namespace TransactionAppIOS.Helper
{
    public class ServiceHelper : IServiceHelper
    {
        HttpClient client = new HttpClient();
        public static ServiceHelper Instance = new ServiceHelper();
        public ServiceHelper()
        {

            //add values To headers 


        }
        public ServiceHelper(HttpClient httpClient) {

            //add values To headers 


        }
        public async Task <TransactionItem> GetTransactionDetails(string TransactionId)
        {
            HttpResponseMessage httpResponseMessage = await client.GetAsync(URl.instance.GetTransactionUrl());
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                string responseContent = await httpResponseMessage.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TransactionItem>(responseContent);


            }
            //handel token expire to for secuirty 
            else if (httpResponseMessage.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                return default;

            }
            return default;
        }

        public async Task <List<TransactionItem>> GetTransactions()
        {
            HttpResponseMessage httpResponseMessage = await client.GetAsync(URl.instance.GetTransactionUrl());
            if (httpResponseMessage.IsSuccessStatusCode)
            {
             string  responseContent    = await httpResponseMessage.Content.ReadAsStringAsync();
                return  JsonConvert.DeserializeObject<List<TransactionItem>>(responseContent);


            }
            //handel token expire to for secuirty 
            else if (httpResponseMessage.StatusCode == System.Net.HttpStatusCode.Unauthorized) { 
             return default(List<TransactionItem>);
            
            }
            return default(List<TransactionItem>);
        }
    }
}