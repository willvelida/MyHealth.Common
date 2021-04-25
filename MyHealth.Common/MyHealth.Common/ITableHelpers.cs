using Microsoft.Azure.Cosmos.Table;
using System.Threading.Tasks;

namespace MyHealth.Common
{
    public interface ITableHelpers
    {
        /// <summary>
        /// Inserts the provided TableEntity object into Table Storage.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task InsertEntityAsync(TableEntity entity);

        /// <summary>
        /// Checks for a duplicate entity in Table Storage with the provided partition key and row key values.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="partitionKey"></param>
        /// <param name="rowKey"></param>
        /// <returns></returns>
        Task<bool> IsDuplicateAsync<T>(string partitionKey, string rowKey);
    }
}
