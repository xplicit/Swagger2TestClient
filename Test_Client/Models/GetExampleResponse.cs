// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// GetExampleResponse
    /// </summary>
    public partial class GetExampleResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetExampleResponse class.
        /// </summary>
        public GetExampleResponse() { }

        /// <summary>
        /// Initializes a new instance of the GetExampleResponse class.
        /// </summary>
        public GetExampleResponse(ResponseStatus responseStatus = default(ResponseStatus), MenuExample menuExample1 = default(MenuExample))
        {
            ResponseStatus = responseStatus;
            MenuExample1 = menuExample1;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponseStatus")]
        public ResponseStatus ResponseStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MenuExample1")]
        public MenuExample MenuExample1 { get; set; }

    }
}
