// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ReturnedDto
    /// </summary>
    public partial class ReturnedDto
    {
        /// <summary>
        /// Initializes a new instance of the ReturnedDto class.
        /// </summary>
        public ReturnedDto() { }

        /// <summary>
        /// Initializes a new instance of the ReturnedDto class.
        /// </summary>
        public ReturnedDto(int? id = default(int?))
        {
            Id = id;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

    }
}
