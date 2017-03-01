// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Authenticate
    /// </summary>
    public partial class Authenticate
    {
        /// <summary>
        /// Initializes a new instance of the Authenticate class.
        /// </summary>
        public Authenticate() { }

        /// <summary>
        /// Initializes a new instance of the Authenticate class.
        /// </summary>
        public Authenticate(string provider = default(string), string state = default(string), string oauthToken = default(string), string oauthVerifier = default(string), string userName = default(string), string password = default(string), bool? rememberMe = default(bool?), string continueProperty = default(string), string nonce = default(string), string uri = default(string), string response = default(string), string qop = default(string), string nc = default(string), string cnonce = default(string), bool? useTokenCookie = default(bool?), object meta = default(object))
        {
            Provider = provider;
            State = state;
            OauthToken = oauthToken;
            OauthVerifier = oauthVerifier;
            UserName = userName;
            Password = password;
            RememberMe = rememberMe;
            ContinueProperty = continueProperty;
            Nonce = nonce;
            Uri = uri;
            Response = response;
            Qop = qop;
            Nc = nc;
            Cnonce = cnonce;
            UseTokenCookie = useTokenCookie;
            Meta = meta;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oauth_token")]
        public string OauthToken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oauth_verifier")]
        public string OauthVerifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserName")]
        public string UserName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RememberMe")]
        public bool? RememberMe { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Continue")]
        public string ContinueProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nonce")]
        public string Nonce { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "response")]
        public string Response { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "qop")]
        public string Qop { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nc")]
        public string Nc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cnonce")]
        public string Cnonce { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UseTokenCookie")]
        public bool? UseTokenCookie { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Meta")]
        public object Meta { get; set; }

    }
}
