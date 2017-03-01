// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestClient
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ThrowValidationOperations.
    /// </summary>
    public static partial class ThrowValidationOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='age'>
            /// </param>
            /// <param name='required'>
            /// </param>
            /// <param name='email'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static ThrowValidationResponse Get(this IThrowValidationOperations operations, int? age = default(int?), string required = default(string), string email = default(string), string format = "json")
            {
                return operations.GetAsync(age, required, email, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='age'>
            /// </param>
            /// <param name='required'>
            /// </param>
            /// <param name='email'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ThrowValidationResponse> GetAsync(this IThrowValidationOperations operations, int? age = default(int?), string required = default(string), string email = default(string), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(age, required, email, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='age'>
            /// </param>
            /// <param name='required'>
            /// </param>
            /// <param name='email'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static ThrowValidationResponse Create(this IThrowValidationOperations operations, int? age = default(int?), string required = default(string), string email = default(string), string format = "json")
            {
                return operations.CreateAsync(age, required, email, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='age'>
            /// </param>
            /// <param name='required'>
            /// </param>
            /// <param name='email'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ThrowValidationResponse> CreateAsync(this IThrowValidationOperations operations, int? age = default(int?), string required = default(string), string email = default(string), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(age, required, email, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='age'>
            /// </param>
            /// <param name='required'>
            /// </param>
            /// <param name='email'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static ThrowValidationResponse Post(this IThrowValidationOperations operations, int? age = default(int?), string required = default(string), string email = default(string), string format = "json")
            {
                return operations.PostAsync(age, required, email, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='age'>
            /// </param>
            /// <param name='required'>
            /// </param>
            /// <param name='email'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ThrowValidationResponse> PostAsync(this IThrowValidationOperations operations, int? age = default(int?), string required = default(string), string email = default(string), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(age, required, email, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='age'>
            /// </param>
            /// <param name='required'>
            /// </param>
            /// <param name='email'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static ThrowValidationResponse Delete(this IThrowValidationOperations operations, int? age = default(int?), string required = default(string), string email = default(string), string format = "json")
            {
                return operations.DeleteAsync(age, required, email, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='age'>
            /// </param>
            /// <param name='required'>
            /// </param>
            /// <param name='email'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ThrowValidationResponse> DeleteAsync(this IThrowValidationOperations operations, int? age = default(int?), string required = default(string), string email = default(string), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(age, required, email, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
