using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using Newtonsoft.Json;

namespace NetCoreForce.FunctionalTests
{
    public class ForceClientFixture : IDisposable
    {
        public AuthInfo AuthInfo { get; private set; }
        public ForceClientFixture()
        {
            string filePath = null;
            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    string executabledirectory = Directory.GetCurrentDirectory();
                    string fileName = "credentials_dev.json";
                    filePath = Path.Combine(executabledirectory, fileName);
                }

                Console.WriteLine("Reading credentials file {0}", filePath);

                string contents = File.ReadAllText(filePath);
                AuthInfo info = JsonConvert.DeserializeObject<AuthInfo>(contents);

                this.AuthInfo = info;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading credentials file: " + ex.Message);
                throw ex;
            }
        }

        public async Task<ForceClient> GetForceClient(string proxyUrl = null)
        {
            HttpClient proxyClient = null;

            if (!string.IsNullOrEmpty(proxyUrl))
            {
                proxyClient = HttpClientFactory.CreateHttpClient(true, proxyUrl);
            }

            var auth = new AuthenticationClient(proxyClient);
            await auth.UsernamePasswordAsync(AuthInfo.ClientId, AuthInfo.ClientSecret,
                    AuthInfo.Username, AuthInfo.Password, AuthInfo.TokenRequestEndpoint);
            var client = new ForceClient(proxyClient).Initialize(auth.AccessInfo.InstanceUrl, auth.ApiVersion, auth.AccessInfo.AccessToken);
            return client;
        }

        public void Dispose()
        {
        }
    }
}