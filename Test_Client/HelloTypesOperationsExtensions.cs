// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestClient
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HelloTypesOperations.
    /// </summary>
    public static partial class HelloTypesOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringParameter'>
            /// </param>
            /// <param name='boolParameter'>
            /// </param>
            /// <param name='intParameter'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static HelloTypes Get(this IHelloTypesOperations operations, string stringParameter = default(string), bool? boolParameter = default(bool?), int? intParameter = default(int?), string format = "json")
            {
                return operations.GetAsync(stringParameter, boolParameter, intParameter, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringParameter'>
            /// </param>
            /// <param name='boolParameter'>
            /// </param>
            /// <param name='intParameter'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HelloTypes> GetAsync(this IHelloTypesOperations operations, string stringParameter = default(string), bool? boolParameter = default(bool?), int? intParameter = default(int?), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(stringParameter, boolParameter, intParameter, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringParameter'>
            /// </param>
            /// <param name='boolParameter'>
            /// </param>
            /// <param name='intParameter'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static HelloTypes Create(this IHelloTypesOperations operations, string stringParameter = default(string), bool? boolParameter = default(bool?), int? intParameter = default(int?), string format = "json")
            {
                return operations.CreateAsync(stringParameter, boolParameter, intParameter, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringParameter'>
            /// </param>
            /// <param name='boolParameter'>
            /// </param>
            /// <param name='intParameter'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HelloTypes> CreateAsync(this IHelloTypesOperations operations, string stringParameter = default(string), bool? boolParameter = default(bool?), int? intParameter = default(int?), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(stringParameter, boolParameter, intParameter, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringParameter'>
            /// </param>
            /// <param name='boolParameter'>
            /// </param>
            /// <param name='intParameter'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static HelloTypes Post(this IHelloTypesOperations operations, string stringParameter = default(string), bool? boolParameter = default(bool?), int? intParameter = default(int?), string format = "json")
            {
                return operations.PostAsync(stringParameter, boolParameter, intParameter, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringParameter'>
            /// </param>
            /// <param name='boolParameter'>
            /// </param>
            /// <param name='intParameter'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HelloTypes> PostAsync(this IHelloTypesOperations operations, string stringParameter = default(string), bool? boolParameter = default(bool?), int? intParameter = default(int?), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(stringParameter, boolParameter, intParameter, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringParameter'>
            /// </param>
            /// <param name='boolParameter'>
            /// </param>
            /// <param name='intParameter'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static HelloTypes Delete(this IHelloTypesOperations operations, string stringParameter = default(string), bool? boolParameter = default(bool?), int? intParameter = default(int?), string format = "json")
            {
                return operations.DeleteAsync(stringParameter, boolParameter, intParameter, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringParameter'>
            /// </param>
            /// <param name='boolParameter'>
            /// </param>
            /// <param name='intParameter'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HelloTypes> DeleteAsync(this IHelloTypesOperations operations, string stringParameter = default(string), bool? boolParameter = default(bool?), int? intParameter = default(int?), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(stringParameter, boolParameter, intParameter, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
