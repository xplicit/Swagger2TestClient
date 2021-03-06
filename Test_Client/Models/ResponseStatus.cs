// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ResponseStatus
    /// </summary>
    public partial class ResponseStatus
    {
        /// <summary>
        /// Initializes a new instance of the ResponseStatus class.
        /// </summary>
        public ResponseStatus() { }

        /// <summary>
        /// Initializes a new instance of the ResponseStatus class.
        /// </summary>
        public ResponseStatus(string errorCode = default(string), string message = default(string), string stackTrace = default(string), IList<ResponseError> errors = default(IList<ResponseError>), object meta = default(object))
        {
            ErrorCode = errorCode;
            Message = message;
            StackTrace = stackTrace;
            Errors = errors;
            Meta = meta;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ErrorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StackTrace")]
        public string StackTrace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Errors")]
        public IList<ResponseError> Errors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Meta")]
        public object Meta { get; set; }

    }
}
