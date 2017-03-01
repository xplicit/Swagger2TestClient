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
    /// EchoCollections
    /// </summary>
    public partial class EchoCollections
    {
        /// <summary>
        /// Initializes a new instance of the EchoCollections class.
        /// </summary>
        public EchoCollections() { }

        /// <summary>
        /// Initializes a new instance of the EchoCollections class.
        /// </summary>
        public EchoCollections(IList<string> stringList = default(IList<string>), IList<string> stringArray = default(IList<string>), object stringMap = default(object), object intStringMap = default(object))
        {
            StringList = stringList;
            StringArray = stringArray;
            StringMap = stringMap;
            IntStringMap = intStringMap;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StringList")]
        public IList<string> StringList { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StringArray")]
        public IList<string> StringArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StringMap")]
        public object StringMap { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IntStringMap")]
        public object IntStringMap { get; set; }

    }
}
