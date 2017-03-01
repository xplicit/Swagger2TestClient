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
    /// GetSession operations.
    /// </summary>
    public partial interface IGetSession
    {
        /// <param name='format'>
        /// Specifies response output format
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="GetSessionResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<GetSessionResponse>> GetWithHttpMessagesAsync(string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='format'>
        /// Specifies response output format
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="GetSessionResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<GetSessionResponse>> CreateWithHttpMessagesAsync(string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='format'>
        /// Specifies response output format
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="GetSessionResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<GetSessionResponse>> PostWithHttpMessagesAsync(string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='format'>
        /// Specifies response output format
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="GetSessionResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<GetSessionResponse>> DeleteWithHttpMessagesAsync(string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}