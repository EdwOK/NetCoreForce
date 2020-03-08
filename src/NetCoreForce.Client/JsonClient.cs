using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NetCoreForce.Client.Models;

namespace NetCoreForce.Client
{
    public class JsonClient
    {
        private const string JsonMimeType = "application/json";

        private readonly HttpClient _httpClient;
        
        private readonly AuthenticationHeaderValue _authHeaderValue;

        /// <summary>
        /// Intialize the JSON client.
        /// <para>By default, uses a shared static HttpClient instance for best performance.</para>
        /// </summary>
        /// <param name="accessToken">API Access token</param>
        /// <param name="httpClient">Optional custom HttpClient. Ideally this should be a shared static instance for best performance.</param>
        public JsonClient(string accessToken, HttpClient httpClient = null)
        {
            _authHeaderValue = new AuthenticationHeaderValue("Bearer", accessToken);

            if (httpClient != null)
            {
                _httpClient = httpClient;
            }
        }

        public async Task<T> HttpGetAsync<T>(Uri uri, Dictionary<string, string> customHeaders = null, bool deserializeResponse = true)
        {
            //TODO: can this handle T = string?
            return await HttpAsync<T>(uri, HttpMethod.Get, null, customHeaders, deserializeResponse);
        }

        public async Task<T> HttpPostAsync<T>(object inputObject, Uri uri, Dictionary<string, string> customHeaders = null, bool deserializeResponse = true)
        {
            var json = JsonSerializer.SerializeForCreate(inputObject);

            var content = new StringContent(json, Encoding.UTF8, JsonMimeType);

            var request = new HttpRequestMessage();
            request.Headers.Authorization = _authHeaderValue;
            request.RequestUri = uri;
            request.Method = HttpMethod.Post;
            request.Content = content;

            return await GetResponse<T>(request, customHeaders, deserializeResponse);
        }

        public async Task<T> HttpPatchAsync<T>(object inputObject, Uri uri, Dictionary<string, string> customHeaders = null, bool deserializeResponse = true, bool serializeComplete = false)
        {
            var json = serializeComplete ?
                JsonSerializer.SerializeComplete(inputObject, false) :
                JsonSerializer.SerializeForUpdate(inputObject);

            var content = new StringContent(json, Encoding.UTF8, JsonMimeType);

            return await HttpAsync<T>(uri, new HttpMethod("PATCH"), content, customHeaders, deserializeResponse);
        }

        public async Task<T> HttpDeleteAsync<T>(Uri uri, Dictionary<string, string> customHeaders = null, bool deserializeResponse = true)
        {
            var request = new HttpRequestMessage();
            request.Headers.Authorization = _authHeaderValue;
            request.RequestUri = uri;
            request.Method = HttpMethod.Delete;

            return await GetResponse<T>(request, customHeaders, deserializeResponse);
        }

        private async Task<T> HttpAsync<T>(Uri uri, HttpMethod httpMethod, HttpContent content = null, Dictionary<string, string> customHeaders = null, bool deserializeResponse = true)
        {
            var request = new HttpRequestMessage();
            request.Headers.Authorization = _authHeaderValue;
            request.RequestUri = uri;
            request.Method = httpMethod;
            if (content != null)
            {
                request.Content = content;
            }

            return await GetResponse<T>(request, customHeaders, deserializeResponse);
        }

        /// <summary>
        /// Get a http client response
        /// </summary>
        /// <param name="request">HttpRequestMessage containing the request details</param>
        /// <param name="customHeaders">Custom headers, if any</param>
        /// <param name="deserializeResponse">Should the response be deserialized for successful (HTTP 2xx) requests. Default is true/yes.
        /// If false/no, this effectively ignores the content of any 2xx type response.
        /// Errors will still be deserialized.</param>
        /// <typeparam name="T">Type used to deserialize the response content</typeparam>
        /// <returns></returns>
        private async Task<T> GetResponse<T>(HttpRequestMessage request, Dictionary<string, string> customHeaders = null, bool deserializeResponse = true)
        {
            if (customHeaders != null && customHeaders.Count > 0)
            {
                foreach (var header in customHeaders)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }

            HttpResponseMessage responseMessage;
            try
            {
                responseMessage = await _httpClient.SendAsync(request).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                var errMsg = "Error sending HTTP request:" + ex.Message;
                if (ex.InnerException != null && !string.IsNullOrEmpty(ex.InnerException.Message))
                {
                    errMsg += $" {ex.InnerException.Message}";
                }
#if DEBUG
                Debug.WriteLine(errMsg);
#endif
                throw new ForceApiException(errMsg);
            }

#if DEBUG
            //API usage response header
            //e.g. "Sforce-Limit-Info: api-usage=90/15000"
            const string SforceLimitInfoHeaderName = "Sforce-Limit-Info";
            var limitValues = GetHeaderValues(responseMessage.Headers, SforceLimitInfoHeaderName);
            if (limitValues != null)
            {
                Debug.WriteLine($"{SforceLimitInfoHeaderName}: {limitValues.FirstOrDefault() ?? "none"}");
            }
#endif

            if (responseMessage.StatusCode == HttpStatusCode.NoContent)
            {
                return JsonConvert.DeserializeObject<T>(string.Empty);
            }

            // successful response, skip deserialization of response content
            if (responseMessage.IsSuccessStatusCode && !deserializeResponse)
            {
                return JsonConvert.DeserializeObject<T>(string.Empty);
            }

            if (responseMessage.Content != null)
            {
                try
                {
                    var responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

                    if (responseMessage.IsSuccessStatusCode)
                    {
                        if (string.IsNullOrEmpty(responseContent))
                        {
                            throw new ForceApiException("Response content was empty");
                        }
                        
                        return JsonConvert.DeserializeObject<T>(responseContent);
                    }
                    if (responseMessage.StatusCode == HttpStatusCode.MultipleChoices)
                    {
                        // Returned when an external ID exists in more than one record
                        // https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/dome_upsert.htm
                        // If the external ID value isn't unique, an HTTP status code 300 is returned, plus a list of the records that matched the query.

                        if (string.IsNullOrEmpty(responseContent))
                        {
                            throw new ForceApiException("Response content was empty");
                        }

                        var results = JsonConvert.DeserializeObject<List<string>>(responseContent);

                        var fex = new ForceApiException("Multiple matches for External ID value, see ObjectUrls")
                        {
                            ObjectUrls = results
                        };

                        throw fex;
                    }

                    var msg = $"Unable to complete request, Salesforce API returned {responseMessage.StatusCode.ToString()}.";

                    List<ErrorResponse> errors = null;

                    try
                    {
                        errors = JsonConvert.DeserializeObject<List<ErrorResponse>>(responseContent);

                        // There will often only be one error code - append this to the message
                        if (errors != null && errors.Count > 0)
                        {
                            msg += $" ErrorCode {errors[0].ErrorCode}: {errors[0].Message}.";
                        }

                        // inform if there are multiple errors that need to be checked
                        if (errors != null && errors.Count > 1)
                        {
                            msg += " Additional errors returned, see Errors for complete list.";
                        }
                    }
                    catch (Exception ex)
                    {
                        msg += $" Unable to parse error details: {ex.Message}";
                    }

                    throw new ForceApiException(msg, errors, responseMessage.StatusCode);
                }
                catch (ForceApiException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw new ForceApiException($"Error parsing response content: {ex.Message}");
                }
            }

            throw new ForceApiException($"Error processing response: returned {responseMessage.ReasonPhrase} for {request.RequestUri.ToString()}");
        }

        /// <summary>
        /// Get values for a particular response header
        /// </summary>
        /// <param name="headers">HttpHeaders from the HttpResponseMessage</param>
        /// <param name="headerName">Header Name</param>
        /// <returns>IEnumerable{string} of header values, if any, Null if none found.</returns>
        private IEnumerable<string> GetHeaderValues(HttpHeaders headers, string headerName)
        {
            if (headers != null)
            {
                if (headers.TryGetValues(headerName, out var values))
                {
                    return values;
                }
            }

#if DEBUG
            Debug.WriteLine($"{headerName} header not found in response");
#endif
            return null;
        }
    }
}