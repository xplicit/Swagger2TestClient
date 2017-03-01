// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestClient
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ImageAsFileOperations.
    /// </summary>
    public static partial class ImageAsFileOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// </param>
            /// <param name='format1'>
            /// Specifies response output format
            /// </param>
            public static string Get(this IImageAsFileOperations operations, string format = default(string), string format1 = "json")
            {
                return operations.GetAsync(format, format1).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// </param>
            /// <param name='format1'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GetAsync(this IImageAsFileOperations operations, string format = default(string), string format1 = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(format, format1, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// </param>
            /// <param name='format1'>
            /// Specifies response output format
            /// </param>
            public static string Create(this IImageAsFileOperations operations, string format = default(string), string format1 = "json")
            {
                return operations.CreateAsync(format, format1).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// </param>
            /// <param name='format1'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> CreateAsync(this IImageAsFileOperations operations, string format = default(string), string format1 = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(format, format1, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// </param>
            /// <param name='format1'>
            /// Specifies response output format
            /// </param>
            public static string Post(this IImageAsFileOperations operations, string format = default(string), string format1 = "json")
            {
                return operations.PostAsync(format, format1).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// </param>
            /// <param name='format1'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> PostAsync(this IImageAsFileOperations operations, string format = default(string), string format1 = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(format, format1, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// </param>
            /// <param name='format1'>
            /// Specifies response output format
            /// </param>
            public static string Delete(this IImageAsFileOperations operations, string format = default(string), string format1 = "json")
            {
                return operations.DeleteAsync(format, format1).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='format'>
            /// </param>
            /// <param name='format1'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> DeleteAsync(this IImageAsFileOperations operations, string format = default(string), string format1 = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(format, format1, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
