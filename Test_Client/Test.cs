// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestClient
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;

    public partial class Test : ServiceClient<Test>, ITest
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Gets the IThrowHttpErrorOperations.
        /// </summary>
        public virtual IThrowHttpErrorOperations ThrowHttpError { get; private set; }

        /// <summary>
        /// Gets the IThrow404Operations.
        /// </summary>
        public virtual IThrow404Operations Throw404 { get; private set; }

        /// <summary>
        /// Gets the IThrowCustom400Operations.
        /// </summary>
        public virtual IThrowCustom400Operations ThrowCustom400 { get; private set; }

        /// <summary>
        /// Gets the IThrowTypeOperations.
        /// </summary>
        public virtual IThrowTypeOperations ThrowType { get; private set; }

        /// <summary>
        /// Gets the IThrowValidationOperations.
        /// </summary>
        public virtual IThrowValidationOperations ThrowValidation { get; private set; }

        /// <summary>
        /// Gets the IThrowBusinessError.
        /// </summary>
        public virtual IThrowBusinessError ThrowBusinessError { get; private set; }

        /// <summary>
        /// Gets the IImageAsStreamOperations.
        /// </summary>
        public virtual IImageAsStreamOperations ImageAsStream { get; private set; }

        /// <summary>
        /// Gets the IImageAsBytesOperations.
        /// </summary>
        public virtual IImageAsBytesOperations ImageAsBytes { get; private set; }

        /// <summary>
        /// Gets the IImageAsCustomResultOperations.
        /// </summary>
        public virtual IImageAsCustomResultOperations ImageAsCustomResult { get; private set; }

        /// <summary>
        /// Gets the IImageWriteToResponseOperations.
        /// </summary>
        public virtual IImageWriteToResponseOperations ImageWriteToResponse { get; private set; }

        /// <summary>
        /// Gets the IImageAsFileOperations.
        /// </summary>
        public virtual IImageAsFileOperations ImageAsFile { get; private set; }

        /// <summary>
        /// Gets the IImageAsRedirectOperations.
        /// </summary>
        public virtual IImageAsRedirectOperations ImageAsRedirect { get; private set; }

        /// <summary>
        /// Gets the IDrawImageOperations.
        /// </summary>
        public virtual IDrawImageOperations DrawImage { get; private set; }

        /// <summary>
        /// Gets the IMetadataTestOperations.
        /// </summary>
        public virtual IMetadataTestOperations MetadataTest { get; private set; }

        /// <summary>
        /// Gets the IMetadataTestArrayOperations.
        /// </summary>
        public virtual IMetadataTestArrayOperations MetadataTestArray { get; private set; }

        /// <summary>
        /// Gets the IGetExample.
        /// </summary>
        public virtual IGetExample GetExample { get; private set; }

        /// <summary>
        /// Gets the IGetRandomIdsOperations.
        /// </summary>
        public virtual IGetRandomIdsOperations GetRandomIds { get; private set; }

        /// <summary>
        /// Gets the ITextFileTestOperations.
        /// </summary>
        public virtual ITextFileTestOperations TextFileTest { get; private set; }

        /// <summary>
        /// Gets the IHelloOperations.
        /// </summary>
        public virtual IHelloOperations Hello { get; private set; }

        /// <summary>
        /// Gets the IHelloAllTypesOperations.
        /// </summary>
        public virtual IHelloAllTypesOperations HelloAllTypes { get; private set; }

        /// <summary>
        /// Gets the IHelloWithRouteOperations.
        /// </summary>
        public virtual IHelloWithRouteOperations HelloWithRoute { get; private set; }

        /// <summary>
        /// Gets the IHelloTypesOperations.
        /// </summary>
        public virtual IHelloTypesOperations HelloTypes { get; private set; }

        /// <summary>
        /// Gets the IHelloZipOperations.
        /// </summary>
        public virtual IHelloZipOperations HelloZip { get; private set; }

        /// <summary>
        /// Gets the IPing.
        /// </summary>
        public virtual IPing Ping { get; private set; }

        /// <summary>
        /// Gets the IRequiresRole.
        /// </summary>
        public virtual IRequiresRole RequiresRole { get; private set; }

        /// <summary>
        /// Gets the IReturnStringOperations.
        /// </summary>
        public virtual IReturnStringOperations ReturnString { get; private set; }

        /// <summary>
        /// Gets the IReturnBytesOperations.
        /// </summary>
        public virtual IReturnBytesOperations ReturnBytes { get; private set; }

        /// <summary>
        /// Gets the IReturnStreamOperations.
        /// </summary>
        public virtual IReturnStreamOperations ReturnStream { get; private set; }

        /// <summary>
        /// Gets the IGetRequest1.
        /// </summary>
        public virtual IGetRequest1 GetRequest1 { get; private set; }

        /// <summary>
        /// Gets the IGetRequest2.
        /// </summary>
        public virtual IGetRequest2 GetRequest2 { get; private set; }

        /// <summary>
        /// Gets the ISendRestGetOperations.
        /// </summary>
        public virtual ISendRestGetOperations SendRestGet { get; private set; }

        /// <summary>
        /// Gets the IGetSession.
        /// </summary>
        public virtual IGetSession GetSession { get; private set; }

        /// <summary>
        /// Gets the IUpdateSessionOperations.
        /// </summary>
        public virtual IUpdateSessionOperations UpdateSession { get; private set; }

        /// <summary>
        /// Gets the ITestAuth.
        /// </summary>
        public virtual ITestAuth TestAuth { get; private set; }

        /// <summary>
        /// Gets the ITestVoidResponse.
        /// </summary>
        public virtual ITestVoidResponse TestVoidResponse { get; private set; }

        /// <summary>
        /// Gets the ITestNullResponse.
        /// </summary>
        public virtual ITestNullResponse TestNullResponse { get; private set; }

        /// <summary>
        /// Gets the IWaitOperations.
        /// </summary>
        public virtual IWaitOperations Wait { get; private set; }

        /// <summary>
        /// Gets the IEchoTypesOperations.
        /// </summary>
        public virtual IEchoTypesOperations EchoTypes { get; private set; }

        /// <summary>
        /// Gets the IEchoCollectionsOperations.
        /// </summary>
        public virtual IEchoCollectionsOperations EchoCollections { get; private set; }

        /// <summary>
        /// Gets the IIdentityTestRequest2Operations.
        /// </summary>
        public virtual IIdentityTestRequest2Operations IdentityTestRequest2 { get; private set; }

        /// <summary>
        /// Gets the IQueryRockstarsOperations.
        /// </summary>
        public virtual IQueryRockstarsOperations QueryRockstars { get; private set; }

        /// <summary>
        /// Gets the IAuthenticateOperations.
        /// </summary>
        public virtual IAuthenticateOperations Authenticate { get; private set; }

        /// <summary>
        /// Gets the IAssignRolesOperations.
        /// </summary>
        public virtual IAssignRolesOperations AssignRoles { get; private set; }

        /// <summary>
        /// Gets the IUnAssignRolesOperations.
        /// </summary>
        public virtual IUnAssignRolesOperations UnAssignRoles { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Test class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public Test(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the Test class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public Test(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the Test class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public Test(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the Test class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public Test(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            ThrowHttpError = new ThrowHttpErrorOperations(this);
            Throw404 = new Throw404Operations(this);
            ThrowCustom400 = new ThrowCustom400Operations(this);
            ThrowType = new ThrowTypeOperations(this);
            ThrowValidation = new ThrowValidationOperations(this);
            ThrowBusinessError = new ThrowBusinessError(this);
            ImageAsStream = new ImageAsStreamOperations(this);
            ImageAsBytes = new ImageAsBytesOperations(this);
            ImageAsCustomResult = new ImageAsCustomResultOperations(this);
            ImageWriteToResponse = new ImageWriteToResponseOperations(this);
            ImageAsFile = new ImageAsFileOperations(this);
            ImageAsRedirect = new ImageAsRedirectOperations(this);
            DrawImage = new DrawImageOperations(this);
            MetadataTest = new MetadataTestOperations(this);
            MetadataTestArray = new MetadataTestArrayOperations(this);
            GetExample = new GetExample(this);
            GetRandomIds = new GetRandomIdsOperations(this);
            TextFileTest = new TextFileTestOperations(this);
            Hello = new HelloOperations(this);
            HelloAllTypes = new HelloAllTypesOperations(this);
            HelloWithRoute = new HelloWithRouteOperations(this);
            HelloTypes = new HelloTypesOperations(this);
            HelloZip = new HelloZipOperations(this);
            Ping = new Ping(this);
            RequiresRole = new RequiresRole(this);
            ReturnString = new ReturnStringOperations(this);
            ReturnBytes = new ReturnBytesOperations(this);
            ReturnStream = new ReturnStreamOperations(this);
            GetRequest1 = new GetRequest1(this);
            GetRequest2 = new GetRequest2(this);
            SendRestGet = new SendRestGetOperations(this);
            GetSession = new GetSession(this);
            UpdateSession = new UpdateSessionOperations(this);
            TestAuth = new TestAuth(this);
            TestVoidResponse = new TestVoidResponse(this);
            TestNullResponse = new TestNullResponse(this);
            Wait = new WaitOperations(this);
            EchoTypes = new EchoTypesOperations(this);
            EchoCollections = new EchoCollectionsOperations(this);
            IdentityTestRequest2 = new IdentityTestRequest2Operations(this);
            QueryRockstars = new QueryRockstarsOperations(this);
            Authenticate = new AuthenticateOperations(this);
            AssignRoles = new AssignRolesOperations(this);
            UnAssignRoles = new UnAssignRolesOperations(this);
            BaseUri = new System.Uri("http://localhost:49204/");
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new  List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
        }
    }
}
