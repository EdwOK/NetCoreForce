using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;

namespace NetCoreForce.FunctionalTests
{
    public class LoginTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;

        public LoginTests(ForceClientFixture fixture)
        {
            this.forceClientFixture = fixture;
        }

        [Fact]
        public async Task UsernamePasswordLoginAuthenticationClientAsync()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            AuthenticationClient auth = new AuthenticationClient(new HttpClient());

            await auth.UsernamePasswordAsync(authInfo.ClientId, authInfo.ClientSecret,
                    authInfo.Username, authInfo.Password, authInfo.TokenRequestEndpoint);
            
            ForceClient client = new ForceClient(new HttpClient()).Initialize(auth.AccessInfo.InstanceUrl, auth.ApiVersion, auth.AccessInfo.AccessToken);

            Assert.True(!string.IsNullOrEmpty(auth.AccessInfo.AccessToken)); //check for access token
            Assert.True(string.IsNullOrEmpty(auth.AccessInfo.RefreshToken)); //this flow should not return a refresh token
        }

        [Fact]
        public async Task UsernamePasswordLoginAuthInfo()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;
            
            ForceClient client = await new ForceClient(new HttpClient()).Initialize(authInfo);

            Assert.True(!string.IsNullOrEmpty(client.AccessInfo.AccessToken)); //check for access token
            Assert.True(string.IsNullOrEmpty(client.AccessInfo.RefreshToken)); //this flow should not return a refresh token
        }

        [Fact]
        public void UsernamePasswordLogin()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            AuthenticationClient auth = new AuthenticationClient(new HttpClient());

            auth.UsernamePassword(authInfo.ClientId, authInfo.ClientSecret,
                    authInfo.Username, authInfo.Password, authInfo.TokenRequestEndpoint);

            ForceClient client = new ForceClient(new HttpClient()).Initialize(auth.AccessInfo.InstanceUrl, auth.ApiVersion, auth.AccessInfo.AccessToken);

            Assert.True(!string.IsNullOrEmpty(auth.AccessInfo.AccessToken)); //check for access token
            Assert.True(string.IsNullOrEmpty(auth.AccessInfo.RefreshToken)); //this flow should not return a refresh token
        }

        [Fact]
        public async Task UsernamePasswordLoginFailAsync()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            AuthenticationClient auth = new AuthenticationClient(new HttpClient());

            ForceAuthException ex = await Assert.ThrowsAsync<ForceAuthException>(
                async () => await auth.UsernamePasswordAsync(authInfo.ClientId, authInfo.ClientSecret, authInfo.Username, "badpassword", authInfo.TokenRequestEndpoint)
            );

            Assert.Equal("invalid_grant", ex.ErrorCode);
            Assert.Equal("authentication failure", ex.Message);
        }

        [Fact]
        public void UsernamePasswordLoginFail()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            AuthenticationClient auth = new AuthenticationClient(new HttpClient());

            ForceAuthException ex = Assert.Throws<ForceAuthException>(() =>
                auth.UsernamePassword(authInfo.ClientId, authInfo.ClientSecret, authInfo.Username, "badpassword", authInfo.TokenRequestEndpoint)
            );

            Assert.Equal("invalid_grant", ex.ErrorCode);
            Assert.Equal("authentication failure", ex.Message);
        }        
    }
}