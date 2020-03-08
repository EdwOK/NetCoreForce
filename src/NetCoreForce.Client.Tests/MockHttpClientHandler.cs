using System;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NetCoreForce.Client.Tests
{
    public class MockHttpClientHandler : DelegatingHandler
    {
        private readonly Dictionary<Uri, HttpResponseMessage> _mockResponses = new Dictionary<Uri, HttpResponseMessage>();

        public void AddMockResponse(Uri uri, HttpResponseMessage responseMessage)
        {
            _mockResponses.Add(uri, responseMessage);
        }

        public void AddMockResponse(Uri uri, HttpStatusCode statusCode, string responseContent)
        {
            var responseMessage = new HttpResponseMessage(statusCode)
            {
                Content = new StringContent(responseContent)
            };

            _mockResponses.Add(uri, responseMessage);
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (_mockResponses.ContainsKey(request.RequestUri))
            {
                //return _MockResponses[request.RequestUri];
                return await Task.FromResult(_mockResponses[request.RequestUri]);
            }
            else
            {
                //return new HttpResponseMessage(HttpStatusCode.NotFound) { RequestMessage = request };
                return await Task.FromResult(new HttpResponseMessage(HttpStatusCode.NotFound) { RequestMessage = request });
            }
        }
    }
}
