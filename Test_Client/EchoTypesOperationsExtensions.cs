// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestClient
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for EchoTypesOperations.
    /// </summary>
    public static partial class EchoTypesOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static EchoTypes Get(this IEchoTypesOperations operations, byte[] byteParameter = default(byte[]), int? shortParameter = default(int?), int? intParameter = default(int?), long? longParameter = default(long?), int? uShortParameter = default(int?), int? uIntParameter = default(int?), long? uLongParameter = default(long?), double? floatParameter = default(double?), double? doubleParameter = default(double?), double? decimalParameter = default(double?), string stringParameter = default(string), System.DateTime? dateTime = default(System.DateTime?), string timeSpan = default(string), string dateTimeOffset = default(string), string guid = default(string), string charParameter = default(string), string format = "json")
            {
                return operations.GetAsync(byteParameter, shortParameter, intParameter, longParameter, uShortParameter, uIntParameter, uLongParameter, floatParameter, doubleParameter, decimalParameter, stringParameter, dateTime, timeSpan, dateTimeOffset, guid, charParameter, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EchoTypes> GetAsync(this IEchoTypesOperations operations, byte[] byteParameter = default(byte[]), int? shortParameter = default(int?), int? intParameter = default(int?), long? longParameter = default(long?), int? uShortParameter = default(int?), int? uIntParameter = default(int?), long? uLongParameter = default(long?), double? floatParameter = default(double?), double? doubleParameter = default(double?), double? decimalParameter = default(double?), string stringParameter = default(string), System.DateTime? dateTime = default(System.DateTime?), string timeSpan = default(string), string dateTimeOffset = default(string), string guid = default(string), string charParameter = default(string), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(byteParameter, shortParameter, intParameter, longParameter, uShortParameter, uIntParameter, uLongParameter, floatParameter, doubleParameter, decimalParameter, stringParameter, dateTime, timeSpan, dateTimeOffset, guid, charParameter, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static EchoTypes Create(this IEchoTypesOperations operations, byte[] byteParameter = default(byte[]), int? shortParameter = default(int?), int? intParameter = default(int?), long? longParameter = default(long?), int? uShortParameter = default(int?), int? uIntParameter = default(int?), long? uLongParameter = default(long?), double? floatParameter = default(double?), double? doubleParameter = default(double?), double? decimalParameter = default(double?), string stringParameter = default(string), System.DateTime? dateTime = default(System.DateTime?), string timeSpan = default(string), string dateTimeOffset = default(string), string guid = default(string), string charParameter = default(string), string format = "json")
            {
                return operations.CreateAsync(byteParameter, shortParameter, intParameter, longParameter, uShortParameter, uIntParameter, uLongParameter, floatParameter, doubleParameter, decimalParameter, stringParameter, dateTime, timeSpan, dateTimeOffset, guid, charParameter, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EchoTypes> CreateAsync(this IEchoTypesOperations operations, byte[] byteParameter = default(byte[]), int? shortParameter = default(int?), int? intParameter = default(int?), long? longParameter = default(long?), int? uShortParameter = default(int?), int? uIntParameter = default(int?), long? uLongParameter = default(long?), double? floatParameter = default(double?), double? doubleParameter = default(double?), double? decimalParameter = default(double?), string stringParameter = default(string), System.DateTime? dateTime = default(System.DateTime?), string timeSpan = default(string), string dateTimeOffset = default(string), string guid = default(string), string charParameter = default(string), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(byteParameter, shortParameter, intParameter, longParameter, uShortParameter, uIntParameter, uLongParameter, floatParameter, doubleParameter, decimalParameter, stringParameter, dateTime, timeSpan, dateTimeOffset, guid, charParameter, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static EchoTypes Post(this IEchoTypesOperations operations, byte[] byteParameter = default(byte[]), int? shortParameter = default(int?), int? intParameter = default(int?), long? longParameter = default(long?), int? uShortParameter = default(int?), int? uIntParameter = default(int?), long? uLongParameter = default(long?), double? floatParameter = default(double?), double? doubleParameter = default(double?), double? decimalParameter = default(double?), string stringParameter = default(string), System.DateTime? dateTime = default(System.DateTime?), string timeSpan = default(string), string dateTimeOffset = default(string), string guid = default(string), string charParameter = default(string), string format = "json")
            {
                return operations.PostAsync(byteParameter, shortParameter, intParameter, longParameter, uShortParameter, uIntParameter, uLongParameter, floatParameter, doubleParameter, decimalParameter, stringParameter, dateTime, timeSpan, dateTimeOffset, guid, charParameter, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EchoTypes> PostAsync(this IEchoTypesOperations operations, byte[] byteParameter = default(byte[]), int? shortParameter = default(int?), int? intParameter = default(int?), long? longParameter = default(long?), int? uShortParameter = default(int?), int? uIntParameter = default(int?), long? uLongParameter = default(long?), double? floatParameter = default(double?), double? doubleParameter = default(double?), double? decimalParameter = default(double?), string stringParameter = default(string), System.DateTime? dateTime = default(System.DateTime?), string timeSpan = default(string), string dateTimeOffset = default(string), string guid = default(string), string charParameter = default(string), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(byteParameter, shortParameter, intParameter, longParameter, uShortParameter, uIntParameter, uLongParameter, floatParameter, doubleParameter, decimalParameter, stringParameter, dateTime, timeSpan, dateTimeOffset, guid, charParameter, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static EchoTypes Delete(this IEchoTypesOperations operations, byte[] byteParameter = default(byte[]), int? shortParameter = default(int?), int? intParameter = default(int?), long? longParameter = default(long?), int? uShortParameter = default(int?), int? uIntParameter = default(int?), long? uLongParameter = default(long?), double? floatParameter = default(double?), double? doubleParameter = default(double?), double? decimalParameter = default(double?), string stringParameter = default(string), System.DateTime? dateTime = default(System.DateTime?), string timeSpan = default(string), string dateTimeOffset = default(string), string guid = default(string), string charParameter = default(string), string format = "json")
            {
                return operations.DeleteAsync(byteParameter, shortParameter, intParameter, longParameter, uShortParameter, uIntParameter, uLongParameter, floatParameter, doubleParameter, decimalParameter, stringParameter, dateTime, timeSpan, dateTimeOffset, guid, charParameter, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EchoTypes> DeleteAsync(this IEchoTypesOperations operations, byte[] byteParameter = default(byte[]), int? shortParameter = default(int?), int? intParameter = default(int?), long? longParameter = default(long?), int? uShortParameter = default(int?), int? uIntParameter = default(int?), long? uLongParameter = default(long?), double? floatParameter = default(double?), double? doubleParameter = default(double?), double? decimalParameter = default(double?), string stringParameter = default(string), System.DateTime? dateTime = default(System.DateTime?), string timeSpan = default(string), string dateTimeOffset = default(string), string guid = default(string), string charParameter = default(string), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(byteParameter, shortParameter, intParameter, longParameter, uShortParameter, uIntParameter, uLongParameter, floatParameter, doubleParameter, decimalParameter, stringParameter, dateTime, timeSpan, dateTimeOffset, guid, charParameter, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
