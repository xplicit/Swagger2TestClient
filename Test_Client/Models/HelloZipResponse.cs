// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// HelloZipResponse
    /// </summary>
    public partial class HelloZipResponse
    {
        /// <summary>
        /// Initializes a new instance of the HelloZipResponse class.
        /// </summary>
        public HelloZipResponse() { }

        /// <summary>
        /// Initializes a new instance of the HelloZipResponse class.
        /// </summary>
        public HelloZipResponse(string result = default(string))
        {
            Result = result;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Result")]
        public string Result { get; set; }

    }
}