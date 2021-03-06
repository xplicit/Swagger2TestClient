// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestClient
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ThrowTypeOperations.
    /// </summary>
    public static partial class ThrowTypeOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='type'>
            /// </param>
            /// <param name='message'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static ThrowTypeResponse Get(this IThrowTypeOperations operations, string type, string message = default(string), string format = "json")
            {
                return operations.GetAsync(type, message, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='type'>
            /// </param>
            /// <param name='message'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ThrowTypeResponse> GetAsync(this IThrowTypeOperations operations, string type, string message = default(string), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(type, message, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='type'>
            /// </param>
            /// <param name='message'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static ThrowTypeResponse Create(this IThrowTypeOperations operations, string type, string message = default(string), string format = "json")
            {
                return operations.CreateAsync(type, message, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='type'>
            /// </param>
            /// <param name='message'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ThrowTypeResponse> CreateAsync(this IThrowTypeOperations operations, string type, string message = default(string), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(type, message, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='type'>
            /// </param>
            /// <param name='message'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static ThrowTypeResponse Post(this IThrowTypeOperations operations, string type, string message = default(string), string format = "json")
            {
                return operations.PostAsync(type, message, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='type'>
            /// </param>
            /// <param name='message'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ThrowTypeResponse> PostAsync(this IThrowTypeOperations operations, string type, string message = default(string), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(type, message, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='type'>
            /// </param>
            /// <param name='message'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static ThrowTypeResponse Delete(this IThrowTypeOperations operations, string type, string message = default(string), string format = "json")
            {
                return operations.DeleteAsync(type, message, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='type'>
            /// </param>
            /// <param name='message'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ThrowTypeResponse> DeleteAsync(this IThrowTypeOperations operations, string type, string message = default(string), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(type, message, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
