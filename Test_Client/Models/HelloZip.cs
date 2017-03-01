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
    /// HelloZip
    /// </summary>
    public partial class HelloZip
    {
        /// <summary>
        /// Initializes a new instance of the HelloZip class.
        /// </summary>
        public HelloZip() { }

        /// <summary>
        /// Initializes a new instance of the HelloZip class.
        /// </summary>
        public HelloZip(string name = default(string), IList<string> testProperty = default(IList<string>))
        {
            Name = name;
            TestProperty = testProperty;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Test")]
        public IList<string> TestProperty { get; set; }

    }
}
