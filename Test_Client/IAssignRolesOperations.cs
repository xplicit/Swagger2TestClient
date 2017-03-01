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
    /// AssignRolesOperations operations.
    /// </summary>
    public partial interface IAssignRolesOperations
    {
        /// <param name='userName'>
        /// </param>
        /// <param name='permissions'>
        /// </param>
        /// <param name='roles'>
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
        /// <exception cref="AssignRolesResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<AssignRolesResponse>> GetWithHttpMessagesAsync(string userName = default(string), IList<string> permissions = default(IList<string>), IList<string> roles = default(IList<string>), string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='userName'>
        /// </param>
        /// <param name='permissions'>
        /// </param>
        /// <param name='roles'>
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
        /// <exception cref="AssignRolesResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<AssignRolesResponse>> CreateWithHttpMessagesAsync(string userName = default(string), IList<string> permissions = default(IList<string>), IList<string> roles = default(IList<string>), string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='userName'>
        /// </param>
        /// <param name='permissions'>
        /// </param>
        /// <param name='roles'>
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
        /// <exception cref="AssignRolesResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<AssignRolesResponse>> PostWithHttpMessagesAsync(string userName = default(string), IList<string> permissions = default(IList<string>), IList<string> roles = default(IList<string>), string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='userName'>
        /// </param>
        /// <param name='permissions'>
        /// </param>
        /// <param name='roles'>
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
        /// <exception cref="AssignRolesResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<AssignRolesResponse>> DeleteWithHttpMessagesAsync(string userName = default(string), IList<string> permissions = default(IList<string>), IList<string> roles = default(IList<string>), string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
