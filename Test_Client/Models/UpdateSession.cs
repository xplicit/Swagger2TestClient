// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// UpdateSession
    /// </summary>
    public partial class UpdateSession
    {
        /// <summary>
        /// Initializes a new instance of the UpdateSession class.
        /// </summary>
        public UpdateSession() { }

        /// <summary>
        /// Initializes a new instance of the UpdateSession class.
        /// </summary>
        public UpdateSession(string customName = default(string))
        {
            CustomName = customName;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CustomName")]
        public string CustomName { get; set; }

    }
}
