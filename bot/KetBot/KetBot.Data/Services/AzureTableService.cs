using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure; // Namespace for CloudConfigurationManager
using Microsoft.WindowsAzure.Storage; // Namespace for CloudStorageAccount
using Microsoft.WindowsAzure.Storage.Table; // Namespace for Table storage types

namespace KetBot.Data.Services
{
    public class AzureTableService<T> : ITableService<T> where T : ITableEntity
    {
        CloudStorageAccount storageAccount;
        CloudTableClient tableClient;

        public AzureTableService()
        {
            storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("AzureStorageConnectionString"));
            tableClient = storageAccount.CreateCloudTableClient();
        }

        public string TableBaseUrl
        {
            get
            {
                return tableClient.BaseUri.ToString();
            }
        }

        public async Task AddMessageAsync(string tablename, T message)
        {
            CloudTable table = tableClient.GetTableReference(tablename);

            TableOperation insertOperation = TableOperation.InsertOrReplace(message);

            await table.ExecuteAsync(insertOperation);
        }

        public async Task CreateTableAsync(string tablename)
        {
            // Retrieve a reference to the table.
            CloudTable table = tableClient.GetTableReference(tablename);
            await table.CreateIfNotExistsAsync();
        }
    }
}
