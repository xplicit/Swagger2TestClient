// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// HelloResponse
    /// </summary>
    public partial class HelloResponse
    {
        /// <summary>
        /// Initializes a new instance of the HelloResponse class.
        /// </summary>
        public HelloResponse() { }

        /// <summary>
        /// Initializes a new instance of the HelloResponse class.
        /// </summary>
        public HelloResponse(string result = default(string))
        {
            Result = result;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Result")]
        public string Result { get; set; }

    }
}
