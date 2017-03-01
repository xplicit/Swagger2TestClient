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
    /// CustomUserSession
    /// </summary>
    public partial class CustomUserSession
    {
        /// <summary>
        /// Initializes a new instance of the CustomUserSession class.
        /// </summary>
        public CustomUserSession() { }

        /// <summary>
        /// Initializes a new instance of the CustomUserSession class.
        /// </summary>
        public CustomUserSession(string customName = default(string), string customInfo = default(string), string referrerUrl = default(string), string id = default(string), string userAuthId = default(string), string userAuthName = default(string), string userName = default(string), string twitterUserId = default(string), string twitterScreenName = default(string), string facebookUserId = default(string), string facebookUserName = default(string), string firstName = default(string), string lastName = default(string), string displayName = default(string), string company = default(string), string email = default(string), string primaryEmail = default(string), string phoneNumber = default(string), System.DateTime? birthDate = default(System.DateTime?), string birthDateRaw = default(string), string address = default(string), string address2 = default(string), string city = default(string), string state = default(string), string country = default(string), string culture = default(string), string fullName = default(string), string gender = default(string), string language = default(string), string mailAddress = default(string), string nickname = default(string), string postalCode = default(string), string timeZone = default(string), string requestTokenSecret = default(string), System.DateTime? createdAt = default(System.DateTime?), System.DateTime? lastModified = default(System.DateTime?), IList<string> roles = default(IList<string>), IList<string> permissions = default(IList<string>), bool? isAuthenticated = default(bool?), bool? fromToken = default(bool?), string profileUrl = default(string), string sequence = default(string), long? tag = default(long?), IList<object> providerOAuthAccess = default(IList<object>))
        {
            CustomName = customName;
            CustomInfo = customInfo;
            ReferrerUrl = referrerUrl;
            Id = id;
            UserAuthId = userAuthId;
            UserAuthName = userAuthName;
            UserName = userName;
            TwitterUserId = twitterUserId;
            TwitterScreenName = twitterScreenName;
            FacebookUserId = facebookUserId;
            FacebookUserName = facebookUserName;
            FirstName = firstName;
            LastName = lastName;
            DisplayName = displayName;
            Company = company;
            Email = email;
            PrimaryEmail = primaryEmail;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
            BirthDateRaw = birthDateRaw;
            Address = address;
            Address2 = address2;
            City = city;
            State = state;
            Country = country;
            Culture = culture;
            FullName = fullName;
            Gender = gender;
            Language = language;
            MailAddress = mailAddress;
            Nickname = nickname;
            PostalCode = postalCode;
            TimeZone = timeZone;
            RequestTokenSecret = requestTokenSecret;
            CreatedAt = createdAt;
            LastModified = lastModified;
            Roles = roles;
            Permissions = permissions;
            IsAuthenticated = isAuthenticated;
            FromToken = fromToken;
            ProfileUrl = profileUrl;
            Sequence = sequence;
            Tag = tag;
            ProviderOAuthAccess = providerOAuthAccess;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CustomName")]
        public string CustomName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CustomInfo")]
        public string CustomInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferrerUrl")]
        public string ReferrerUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserAuthId")]
        public string UserAuthId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserAuthName")]
        public string UserAuthName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserName")]
        public string UserName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TwitterUserId")]
        public string TwitterUserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TwitterScreenName")]
        public string TwitterScreenName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FacebookUserId")]
        public string FacebookUserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FacebookUserName")]
        public string FacebookUserName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastName")]
        public string LastName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Company")]
        public string Company { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrimaryEmail")]
        public string PrimaryEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PhoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BirthDate")]
        public System.DateTime? BirthDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BirthDateRaw")]
        public string BirthDateRaw { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "City")]
        public string City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Country")]
        public string Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Culture")]
        public string Culture { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FullName")]
        public string FullName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Gender")]
        public string Gender { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Language")]
        public string Language { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MailAddress")]
        public string MailAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PostalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TimeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RequestTokenSecret")]
        public string RequestTokenSecret { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatedAt")]
        public System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastModified")]
        public System.DateTime? LastModified { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Roles")]
        public IList<string> Roles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Permissions")]
        public IList<string> Permissions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsAuthenticated")]
        public bool? IsAuthenticated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FromToken")]
        public bool? FromToken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProfileUrl")]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Sequence")]
        public string Sequence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Tag")]
        public long? Tag { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProviderOAuthAccess")]
        public IList<object> ProviderOAuthAccess { get; set; }

    }
}
