// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestClient
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// DrawImageOperations operations.
    /// </summary>
    public partial class DrawImageOperations : IServiceOperations<Test>, IDrawImageOperations
    {
        /// <summary>
        /// Initializes a new instance of the DrawImageOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DrawImageOperations(Test client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the Test
        /// </summary>
        public Test Client { get; private set; }

        /// <param name='name'>
        /// </param>
        /// <param name='format'>
        /// </param>
        /// <param name='width'>
        /// </param>
        /// <param name='height'>
        /// </param>
        /// <param name='fontSize'>
        /// </param>
        /// <param name='foreground'>
        /// </param>
        /// <param name='background'>
        /// </param>
        /// <param name='format1'>
        /// Specifies response output format
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<object>> GetWithHttpMessagesAsync(string name, string format = default(string), int? width = default(int?), int? height = default(int?), int? fontSize = default(int?), string foreground = default(string), string background = default(string), string format1 = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "name");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("name", name);
                tracingParameters.Add("format", format);
                tracingParameters.Add("width", width);
                tracingParameters.Add("height", height);
                tracingParameters.Add("fontSize", fontSize);
                tracingParameters.Add("foreground", foreground);
                tracingParameters.Add("background", background);
                tracingParameters.Add("format1", format1);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "Get", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "image-draw/{Name}").ToString();
            _url = _url.Replace("{Name}", System.Uri.EscapeDataString(name));
            List<string> _queryParameters = new List<string>();
            if (format != null)
            {
                _queryParameters.Add(string.Format("Format={0}", System.Uri.EscapeDataString(format)));
            }
            if (width != null)
            {
                _queryParameters.Add(string.Format("Width={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(width, Client.SerializationSettings).Trim('"'))));
            }
            if (height != null)
            {
                _queryParameters.Add(string.Format("Height={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(height, Client.SerializationSettings).Trim('"'))));
            }
            if (fontSize != null)
            {
                _queryParameters.Add(string.Format("FontSize={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(fontSize, Client.SerializationSettings).Trim('"'))));
            }
            if (foreground != null)
            {
                _queryParameters.Add(string.Format("Foreground={0}", System.Uri.EscapeDataString(foreground)));
            }
            if (background != null)
            {
                _queryParameters.Add(string.Format("Background={0}", System.Uri.EscapeDataString(background)));
            }
            if (format1 != null)
            {
                _queryParameters.Add(string.Format("format={0}", System.Uri.EscapeDataString(format1)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if (!_httpResponse.IsSuccessStatusCode)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    object _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<object>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<object>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            string _defaultResponseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            try
            {
                _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<object>(_defaultResponseContent, Client.DeserializationSettings);
            }
            catch (JsonException ex)
            {
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw new SerializationException("Unable to deserialize the response.", _defaultResponseContent, ex);
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <param name='name'>
        /// </param>
        /// <param name='format'>
        /// </param>
        /// <param name='width'>
        /// </param>
        /// <param name='height'>
        /// </param>
        /// <param name='fontSize'>
        /// </param>
        /// <param name='foreground'>
        /// </param>
        /// <param name='background'>
        /// </param>
        /// <param name='format1'>
        /// Specifies response output format
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<object>> CreateWithHttpMessagesAsync(string name, string format = default(string), int? width = default(int?), int? height = default(int?), int? fontSize = default(int?), string foreground = default(string), string background = default(string), string format1 = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "name");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("name", name);
                tracingParameters.Add("format", format);
                tracingParameters.Add("width", width);
                tracingParameters.Add("height", height);
                tracingParameters.Add("fontSize", fontSize);
                tracingParameters.Add("foreground", foreground);
                tracingParameters.Add("background", background);
                tracingParameters.Add("format1", format1);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "Create", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "image-draw/{Name}").ToString();
            _url = _url.Replace("{Name}", System.Uri.EscapeDataString(name));
            List<string> _queryParameters = new List<string>();
            if (format1 != null)
            {
                _queryParameters.Add(string.Format("format={0}", System.Uri.EscapeDataString(format1)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("PUT");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            MultipartFormDataContent _multiPartContent = new MultipartFormDataContent();
            if (format != null)
            {
                StringContent _format = new StringContent(format, System.Text.Encoding.UTF8);
                _multiPartContent.Add(_format, "Format");
            }
            if (width != null)
            {
                StringContent _width = new StringContent(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(width, Client.SerializationSettings).Trim('"'), System.Text.Encoding.UTF8);
                _multiPartContent.Add(_width, "Width");
            }
            if (height != null)
            {
                StringContent _height = new StringContent(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(height, Client.SerializationSettings).Trim('"'), System.Text.Encoding.UTF8);
                _multiPartContent.Add(_height, "Height");
            }
            if (fontSize != null)
            {
                StringContent _fontSize = new StringContent(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(fontSize, Client.SerializationSettings).Trim('"'), System.Text.Encoding.UTF8);
                _multiPartContent.Add(_fontSize, "FontSize");
            }
            if (foreground != null)
            {
                StringContent _foreground = new StringContent(foreground, System.Text.Encoding.UTF8);
                _multiPartContent.Add(_foreground, "Foreground");
            }
            if (background != null)
            {
                StringContent _background = new StringContent(background, System.Text.Encoding.UTF8);
                _multiPartContent.Add(_background, "Background");
            }
            _httpRequest.Content = _multiPartContent;
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if (!_httpResponse.IsSuccessStatusCode)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    object _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<object>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<object>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            string _defaultResponseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            try
            {
                _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<object>(_defaultResponseContent, Client.DeserializationSettings);
            }
            catch (JsonException ex)
            {
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw new SerializationException("Unable to deserialize the response.", _defaultResponseContent, ex);
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <param name='name'>
        /// </param>
        /// <param name='format'>
        /// </param>
        /// <param name='width'>
        /// </param>
        /// <param name='height'>
        /// </param>
        /// <param name='fontSize'>
        /// </param>
        /// <param name='foreground'>
        /// </param>
        /// <param name='background'>
        /// </param>
        /// <param name='format1'>
        /// Specifies response output format
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<object>> PostWithHttpMessagesAsync(string name, string format = default(string), int? width = default(int?), int? height = default(int?), int? fontSize = default(int?), string foreground = default(string), string background = default(string), string format1 = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "name");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("name", name);
                tracingParameters.Add("format", format);
                tracingParameters.Add("width", width);
                tracingParameters.Add("height", height);
                tracingParameters.Add("fontSize", fontSize);
                tracingParameters.Add("foreground", foreground);
                tracingParameters.Add("background", background);
                tracingParameters.Add("format1", format1);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "Post", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "image-draw/{Name}").ToString();
            _url = _url.Replace("{Name}", System.Uri.EscapeDataString(name));
            List<string> _queryParameters = new List<string>();
            if (format1 != null)
            {
                _queryParameters.Add(string.Format("format={0}", System.Uri.EscapeDataString(format1)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("POST");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            MultipartFormDataContent _multiPartContent = new MultipartFormDataContent();
            if (format != null)
            {
                StringContent _format = new StringContent(format, System.Text.Encoding.UTF8);
                _multiPartContent.Add(_format, "Format");
            }
            if (width != null)
            {
                StringContent _width = new StringContent(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(width, Client.SerializationSettings).Trim('"'), System.Text.Encoding.UTF8);
                _multiPartContent.Add(_width, "Width");
            }
            if (height != null)
            {
                StringContent _height = new StringContent(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(height, Client.SerializationSettings).Trim('"'), System.Text.Encoding.UTF8);
                _multiPartContent.Add(_height, "Height");
            }
            if (fontSize != null)
            {
                StringContent _fontSize = new StringContent(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(fontSize, Client.SerializationSettings).Trim('"'), System.Text.Encoding.UTF8);
                _multiPartContent.Add(_fontSize, "FontSize");
            }
            if (foreground != null)
            {
                StringContent _foreground = new StringContent(foreground, System.Text.Encoding.UTF8);
                _multiPartContent.Add(_foreground, "Foreground");
            }
            if (background != null)
            {
                StringContent _background = new StringContent(background, System.Text.Encoding.UTF8);
                _multiPartContent.Add(_background, "Background");
            }
            _httpRequest.Content = _multiPartContent;
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if (!_httpResponse.IsSuccessStatusCode)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    object _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<object>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<object>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            string _defaultResponseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            try
            {
                _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<object>(_defaultResponseContent, Client.DeserializationSettings);
            }
            catch (JsonException ex)
            {
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw new SerializationException("Unable to deserialize the response.", _defaultResponseContent, ex);
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <param name='name'>
        /// </param>
        /// <param name='format'>
        /// </param>
        /// <param name='width'>
        /// </param>
        /// <param name='height'>
        /// </param>
        /// <param name='fontSize'>
        /// </param>
        /// <param name='foreground'>
        /// </param>
        /// <param name='background'>
        /// </param>
        /// <param name='format1'>
        /// Specifies response output format
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<object>> DeleteWithHttpMessagesAsync(string name, string format = default(string), int? width = default(int?), int? height = default(int?), int? fontSize = default(int?), string foreground = default(string), string background = default(string), string format1 = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "name");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("name", name);
                tracingParameters.Add("format", format);
                tracingParameters.Add("width", width);
                tracingParameters.Add("height", height);
                tracingParameters.Add("fontSize", fontSize);
                tracingParameters.Add("foreground", foreground);
                tracingParameters.Add("background", background);
                tracingParameters.Add("format1", format1);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "Delete", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "image-draw/{Name}").ToString();
            _url = _url.Replace("{Name}", System.Uri.EscapeDataString(name));
            List<string> _queryParameters = new List<string>();
            if (format != null)
            {
                _queryParameters.Add(string.Format("Format={0}", System.Uri.EscapeDataString(format)));
            }
            if (width != null)
            {
                _queryParameters.Add(string.Format("Width={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(width, Client.SerializationSettings).Trim('"'))));
            }
            if (height != null)
            {
                _queryParameters.Add(string.Format("Height={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(height, Client.SerializationSettings).Trim('"'))));
            }
            if (fontSize != null)
            {
                _queryParameters.Add(string.Format("FontSize={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(fontSize, Client.SerializationSettings).Trim('"'))));
            }
            if (foreground != null)
            {
                _queryParameters.Add(string.Format("Foreground={0}", System.Uri.EscapeDataString(foreground)));
            }
            if (background != null)
            {
                _queryParameters.Add(string.Format("Background={0}", System.Uri.EscapeDataString(background)));
            }
            if (format1 != null)
            {
                _queryParameters.Add(string.Format("format={0}", System.Uri.EscapeDataString(format1)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("DELETE");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if (!_httpResponse.IsSuccessStatusCode)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    object _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<object>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<object>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            string _defaultResponseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            try
            {
                _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<object>(_defaultResponseContent, Client.DeserializationSettings);
            }
            catch (JsonException ex)
            {
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw new SerializationException("Unable to deserialize the response.", _defaultResponseContent, ex);
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
