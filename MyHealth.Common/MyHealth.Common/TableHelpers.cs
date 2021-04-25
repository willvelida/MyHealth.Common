using Microsoft.Azure.Cosmos.Table;
using System;
using System.Threading.Tasks;

namespace MyHealth.Common
{
    public class TableHelpers : ITableHelpers
    {
        private CloudStorageAccount _cloudStorageAccount;
        private CloudTable _cloudTable;

        public TableHelpers(string connectionString, string tableName)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            if (string.IsNullOrEmpty(tableName))
                throw new ArgumentNullException(nameof(tableName));

            _cloudStorageAccount = CloudStorageAccount.Parse(connectionString);
            CloudTableClient tableClient = _cloudStorageAccount.CreateCloudTableClient();
            _cloudTable = tableClient.GetTableReference(tableName);
        }

        public async Task InsertEntityAsync(TableEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            try
            {
                TableOperation insertOperation = TableOperation.Insert(entity);
                TableResult result = await _cloudTable.ExecuteAsync(insertOperation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> IsDuplicateAsync<TableEntity>(string partitionKey, string rowKey)
        {
            bool isDuplicate;

            try
            {
                TableOperation retrieveOperation = TableOperation.Retrieve(partitionKey, rowKey);
                TableResult result = await _cloudTable.ExecuteAsync(retrieveOperation);

                if (result.HttpStatusCode == (int)System.Net.HttpStatusCode.NotFound)
                {
                    isDuplicate = false;
                }
                else
                {
                    isDuplicate = true;
                }

                return isDuplicate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
