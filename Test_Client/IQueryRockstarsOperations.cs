// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestClient
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// QueryRockstarsOperations operations.
    /// </summary>
    public partial interface IQueryRockstarsOperations
    {
        /// <param name='skip'>
        /// </param>
        /// <param name='take'>
        /// </param>
        /// <param name='orderBy'>
        /// </param>
        /// <param name='orderByDesc'>
        /// </param>
        /// <param name='include'>
        /// </param>
        /// <param name='fields'>
        /// </param>
        /// <param name='meta'>
        /// </param>
        /// <param name='format'>
        /// Specifies response output format
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="QueryResponseRockstarException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<QueryResponseRockstar>> GetWithHttpMessagesAsync(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string orderByDesc = default(string), string include = default(string), string fields = default(string), object meta = default(object), string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='skip'>
        /// </param>
        /// <param name='take'>
        /// </param>
        /// <param name='orderBy'>
        /// </param>
        /// <param name='orderByDesc'>
        /// </param>
        /// <param name='include'>
        /// </param>
        /// <param name='fields'>
        /// </param>
        /// <param name='meta'>
        /// </param>
        /// <param name='format'>
        /// Specifies response output format
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="QueryResponseRockstarException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<QueryResponseRockstar>> CreateWithHttpMessagesAsync(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string orderByDesc = default(string), string include = default(string), string fields = default(string), object meta = default(object), string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='skip'>
        /// </param>
        /// <param name='take'>
        /// </param>
        /// <param name='orderBy'>
        /// </param>
        /// <param name='orderByDesc'>
        /// </param>
        /// <param name='include'>
        /// </param>
        /// <param name='fields'>
        /// </param>
        /// <param name='meta'>
        /// </param>
        /// <param name='format'>
        /// Specifies response output format
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="QueryResponseRockstarException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<QueryResponseRockstar>> PostWithHttpMessagesAsync(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string orderByDesc = default(string), string include = default(string), string fields = default(string), object meta = default(object), string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='skip'>
        /// </param>
        /// <param name='take'>
        /// </param>
        /// <param name='orderBy'>
        /// </param>
        /// <param name='orderByDesc'>
        /// </param>
        /// <param name='include'>
        /// </param>
        /// <param name='fields'>
        /// </param>
        /// <param name='meta'>
        /// </param>
        /// <param name='format'>
        /// Specifies response output format
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="QueryResponseRockstarException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<QueryResponseRockstar>> DeleteWithHttpMessagesAsync(int? skip = default(int?), int? take = default(int?), string orderBy = default(string), string orderByDesc = default(string), string include = default(string), string fields = default(string), object meta = default(object), string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}