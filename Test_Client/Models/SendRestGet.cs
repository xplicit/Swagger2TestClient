// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SendRestGet
    /// </summary>
    public partial class SendRestGet
    {
        /// <summary>
        /// Initializes a new instance of the SendRestGet class.
        /// </summary>
        public SendRestGet() { }

        /// <summary>
        /// Initializes a new instance of the SendRestGet class.
        /// </summary>
        public SendRestGet(int? id = default(int?))
        {
            Id = id;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

    }
}