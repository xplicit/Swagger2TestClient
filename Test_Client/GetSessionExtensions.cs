// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestClient
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GetSession.
    /// </summary>
    public static partial class GetSessionExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static GetSessionResponse Get(this IGetSession operations, string format = "json")
            {
                return operations.GetAsync(format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetSessionResponse> GetAsync(this IGetSession operations, string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static GetSessionResponse Create(this IGetSession operations, string format = "json")
            {
                return operations.CreateAsync(format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetSessionResponse> CreateAsync(this IGetSession operations, string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static GetSessionResponse Post(this IGetSession operations, string format = "json")
            {
                return operations.PostAsync(format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetSessionResponse> PostAsync(this IGetSession operations, string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static GetSessionResponse Delete(this IGetSession operations, string format = "json")
            {
                return operations.DeleteAsync(format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetSessionResponse> DeleteAsync(this IGetSession operations, string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
