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
    /// AssignRolesResponse
    /// </summary>
    public partial class AssignRolesResponse
    {
        /// <summary>
        /// Initializes a new instance of the AssignRolesResponse class.
        /// </summary>
        public AssignRolesResponse() { }

        /// <summary>
        /// Initializes a new instance of the AssignRolesResponse class.
        /// </summary>
        public AssignRolesResponse(IList<string> allRoles = default(IList<string>), IList<string> allPermissions = default(IList<string>), ResponseStatus responseStatus = default(ResponseStatus))
        {
            AllRoles = allRoles;
            AllPermissions = allPermissions;
            ResponseStatus = responseStatus;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllRoles")]
        public IList<string> AllRoles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllPermissions")]
        public IList<string> AllPermissions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ResponseStatus")]
        public ResponseStatus ResponseStatus { get; set; }

    }
}
