using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    public class LoginArgumentExceptionTests
    {
        private const string DefaultTokenRequestEndpoint = "https://login.salesforce.com/services/oauth2/token";

        [Fact]
        public void MalformedTokenRequestEndpoint()
        {
            AuthenticationClient auth = new AuthenticationClient(new HttpClient());

            FormatException ex = Assert.Throws<FormatException>(() =>
                auth.UsernamePassword("ClientId", "ClientSecret", "username", "badpassword", "malformed_tokenRequestEndpoint")
            );

            Assert.Contains("tokenRequestEndpointUrl", ex.Message);
        }

        [Fact]
        public async Task ForceClientAndAuthenticationClientThrowSameError()
        {
            //check that the ForceClient and AuthenticationClient both throw the same argument exception
            AuthenticationClient auth = new AuthenticationClient(new HttpClient());

            ArgumentNullException acex = await Assert.ThrowsAsync<ArgumentNullException>(async () =>
            {
                await new ForceClient(new HttpClient()).Initialize("ClientId", "ClientSecret", "username", "", DefaultTokenRequestEndpoint);
            });

            ArgumentNullException fcex = Assert.Throws<ArgumentNullException>(() =>
                auth.UsernamePassword("ClientId", "ClientSecret", "username", "", DefaultTokenRequestEndpoint)
            );

            Assert.True(fcex.GetType() == acex.GetType());
            Assert.True(acex.Message == fcex.Message);
        }

        [Fact]
        public async Task EmptyClientIdArgumentNullExceptionAsync()
        {
            ArgumentNullException ex = await Assert.ThrowsAsync<ArgumentNullException>(async () =>
            {
                await new ForceClient(new HttpClient()).Initialize(null, "ClientSecret", "username", "password", DefaultTokenRequestEndpoint);
            });

            Assert.Contains("clientid", ex.Message.ToLower());
        }

        [Fact]
        public async Task EmptyClientSecretArgumentNullException()
        {
            ArgumentNullException ex = await Assert.ThrowsAsync<ArgumentNullException>(async () =>
            {
                await new ForceClient(new HttpClient()).Initialize("ClientId", null, "username", "password", DefaultTokenRequestEndpoint);
            });

            Assert.Contains("clientsecret", ex.Message.ToLower());
        }

        [Fact]
        public async Task EmptyUsernameArgumentNullException()
        {
            ArgumentNullException ex = await Assert.ThrowsAsync<ArgumentNullException>(async () =>
            {
                await new ForceClient(new HttpClient()).Initialize("ClientId", "ClientSecret", null, "password", DefaultTokenRequestEndpoint);
            });

            Assert.Contains("username", ex.Message.ToLower());
        }

        [Fact]
        public async Task EmptyPasswordArgumentNullException()
        {
            ArgumentNullException ex = await Assert.ThrowsAsync<ArgumentNullException>(async () =>
            {
                await new ForceClient(new HttpClient()).Initialize("ClientId", "ClientSecret", "username", null, DefaultTokenRequestEndpoint);
            });

            Assert.Contains("password", ex.Message.ToLower());
        }
    }
}