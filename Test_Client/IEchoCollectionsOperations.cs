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
    /// EchoCollectionsOperations operations.
    /// </summary>
    public partial interface IEchoCollectionsOperations
    {
        /// <param name='stringList'>
        /// </param>
        /// <param name='stringArray'>
        /// </param>
        /// <param name='stringMap'>
        /// </param>
        /// <param name='intStringMap'>
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
        /// <exception cref="EchoCollectionsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<EchoCollections>> GetWithHttpMessagesAsync(IList<string> stringList = default(IList<string>), IList<string> stringArray = default(IList<string>), object stringMap = default(object), object intStringMap = default(object), string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='stringList'>
        /// </param>
        /// <param name='stringArray'>
        /// </param>
        /// <param name='stringMap'>
        /// </param>
        /// <param name='intStringMap'>
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
        /// <exception cref="EchoCollectionsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<EchoCollections>> CreateWithHttpMessagesAsync(IList<string> stringList = default(IList<string>), IList<string> stringArray = default(IList<string>), object stringMap = default(object), object intStringMap = default(object), string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='stringList'>
        /// </param>
        /// <param name='stringArray'>
        /// </param>
        /// <param name='stringMap'>
        /// </param>
        /// <param name='intStringMap'>
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
        /// <exception cref="EchoCollectionsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<EchoCollections>> PostWithHttpMessagesAsync(IList<string> stringList = default(IList<string>), IList<string> stringArray = default(IList<string>), object stringMap = default(object), object intStringMap = default(object), string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='stringList'>
        /// </param>
        /// <param name='stringArray'>
        /// </param>
        /// <param name='stringMap'>
        /// </param>
        /// <param name='intStringMap'>
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
        /// <exception cref="EchoCollectionsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<EchoCollections>> DeleteWithHttpMessagesAsync(IList<string> stringList = default(IList<string>), IList<string> stringArray = default(IList<string>), object stringMap = default(object), object intStringMap = default(object), string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}