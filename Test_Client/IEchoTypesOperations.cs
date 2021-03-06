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
    /// EchoTypesOperations operations.
    /// </summary>
    public partial interface IEchoTypesOperations
    {
        /// <param name='byteParameter'>
        /// </param>
        /// <param name='shortParameter'>
        /// </param>
        /// <param name='intParameter'>
        /// </param>
        /// <param name='longParameter'>
        /// </param>
        /// <param name='uShortParameter'>
        /// </param>
        /// <param name='uIntParameter'>
        /// </param>
        /// <param name='uLongParameter'>
        /// </param>
        /// <param name='floatParameter'>
        /// </param>
        /// <param name='doubleParameter'>
        /// </param>
        /// <param name='decimalParameter'>
        /// </param>
        /// <param name='stringParameter'>
        /// </param>
        /// <param name='dateTime'>
        /// </param>
        /// <param name='timeSpan'>
        /// </param>
        /// <param name='dateTimeOffset'>
        /// </param>
        /// <param name='guid'>
        /// </param>
        /// <param name='charParameter'>
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
        /// <exception cref="EchoTypesException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<EchoTypes>> GetWithHttpMessagesAsync(int? byteParameter = default(int?), int? shortParameter = default(int?), int? intParameter = default(int?), long? longParameter = default(long?), int? uShortParameter = default(int?), int? uIntParameter = default(int?), long? uLongParameter = default(long?), double? floatParameter = default(double?), double? doubleParameter = default(double?), double? decimalParameter = default(double?), string stringParameter = default(string), System.DateTime? dateTime = default(System.DateTime?), string timeSpan = default(string), string dateTimeOffset = default(string), string guid = default(string), string charParameter = default(string), string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='byteParameter'>
        /// </param>
        /// <param name='shortParameter'>
        /// </param>
        /// <param name='intParameter'>
        /// </param>
        /// <param name='longParameter'>
        /// </param>
        /// <param name='uShortParameter'>
        /// </param>
        /// <param name='uIntParameter'>
        /// </param>
        /// <param name='uLongParameter'>
        /// </param>
        /// <param name='floatParameter'>
        /// </param>
        /// <param name='doubleParameter'>
        /// </param>
        /// <param name='decimalParameter'>
        /// </param>
        /// <param name='stringParameter'>
        /// </param>
        /// <param name='dateTime'>
        /// </param>
        /// <param name='timeSpan'>
        /// </param>
        /// <param name='dateTimeOffset'>
        /// </param>
        /// <param name='guid'>
        /// </param>
        /// <param name='charParameter'>
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
        /// <exception cref="EchoTypesException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<EchoTypes>> CreateWithHttpMessagesAsync(int? byteParameter = default(int?), int? shortParameter = default(int?), int? intParameter = default(int?), long? longParameter = default(long?), int? uShortParameter = default(int?), int? uIntParameter = default(int?), long? uLongParameter = default(long?), double? floatParameter = default(double?), double? doubleParameter = default(double?), double? decimalParameter = default(double?), string stringParameter = default(string), System.DateTime? dateTime = default(System.DateTime?), string timeSpan = default(string), string dateTimeOffset = default(string), string guid = default(string), string charParameter = default(string), string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='byteParameter'>
        /// </param>
        /// <param name='shortParameter'>
        /// </param>
        /// <param name='intParameter'>
        /// </param>
        /// <param name='longParameter'>
        /// </param>
        /// <param name='uShortParameter'>
        /// </param>
        /// <param name='uIntParameter'>
        /// </param>
        /// <param name='uLongParameter'>
        /// </param>
        /// <param name='floatParameter'>
        /// </param>
        /// <param name='doubleParameter'>
        /// </param>
        /// <param name='decimalParameter'>
        /// </param>
        /// <param name='stringParameter'>
        /// </param>
        /// <param name='dateTime'>
        /// </param>
        /// <param name='timeSpan'>
        /// </param>
        /// <param name='dateTimeOffset'>
        /// </param>
        /// <param name='guid'>
        /// </param>
        /// <param name='charParameter'>
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
        /// <exception cref="EchoTypesException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<EchoTypes>> PostWithHttpMessagesAsync(int? byteParameter = default(int?), int? shortParameter = default(int?), int? intParameter = default(int?), long? longParameter = default(long?), int? uShortParameter = default(int?), int? uIntParameter = default(int?), long? uLongParameter = default(long?), double? floatParameter = default(double?), double? doubleParameter = default(double?), double? decimalParameter = default(double?), string stringParameter = default(string), System.DateTime? dateTime = default(System.DateTime?), string timeSpan = default(string), string dateTimeOffset = default(string), string guid = default(string), string charParameter = default(string), string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='byteParameter'>
        /// </param>
        /// <param name='shortParameter'>
        /// </param>
        /// <param name='intParameter'>
        /// </param>
        /// <param name='longParameter'>
        /// </param>
        /// <param name='uShortParameter'>
        /// </param>
        /// <param name='uIntParameter'>
        /// </param>
        /// <param name='uLongParameter'>
        /// </param>
        /// <param name='floatParameter'>
        /// </param>
        /// <param name='doubleParameter'>
        /// </param>
        /// <param name='decimalParameter'>
        /// </param>
        /// <param name='stringParameter'>
        /// </param>
        /// <param name='dateTime'>
        /// </param>
        /// <param name='timeSpan'>
        /// </param>
        /// <param name='dateTimeOffset'>
        /// </param>
        /// <param name='guid'>
        /// </param>
        /// <param name='charParameter'>
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
        /// <exception cref="EchoTypesException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<EchoTypes>> DeleteWithHttpMessagesAsync(int? byteParameter = default(int?), int? shortParameter = default(int?), int? intParameter = default(int?), long? longParameter = default(long?), int? uShortParameter = default(int?), int? uIntParameter = default(int?), long? uLongParameter = default(long?), double? floatParameter = default(double?), double? doubleParameter = default(double?), double? decimalParameter = default(double?), string stringParameter = default(string), System.DateTime? dateTime = default(System.DateTime?), string timeSpan = default(string), string dateTimeOffset = default(string), string guid = default(string), string charParameter = default(string), string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
