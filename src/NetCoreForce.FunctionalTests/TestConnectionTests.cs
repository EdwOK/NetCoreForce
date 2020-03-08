using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace NetCoreForce.FunctionalTests
{
    public class TestConnectionTests : IClassFixture<ForceClientFixture>
    {
        private readonly ForceClientFixture _forceClientFixture;
        private readonly ITestOutputHelper _testOutputHelper;

        public TestConnectionTests(ForceClientFixture fixture, ITestOutputHelper testOutputHelper)
        {
            this._forceClientFixture = fixture;
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public async Task TestConnectionBadUrl()
        {
            AuthInfo authInfo = _forceClientFixture.AuthInfo;
            ForceClient client = await new ForceClient(new HttpClient()).Initialize(authInfo);

            Assert.False(client.TestConnection("https://badurl"));
            Assert.False(client.TestConnection("malformedurl"));
        }

        [Fact]
        public async Task TestConnection()
        {
            AuthInfo authInfo = _forceClientFixture.AuthInfo;
            ForceClient client = await new ForceClient(new HttpClient()).Initialize(authInfo);

            Stopwatch sw = new Stopwatch();
            Assert.True(client.TestConnection());
            sw.Stop();
            _testOutputHelper.WriteLine($"TestConnection() took {sw.ElapsedMilliseconds.ToString()}ms");
        }

        [Fact]
        public async Task TestConnectionToNa1()
        {
            AuthInfo authInfo = _forceClientFixture.AuthInfo;
            ForceClient client = await new ForceClient(new HttpClient()).Initialize(authInfo);

            //Barring any major server reorg in Salesforce, the NA1 production instance should always be there.
            //If this test fails, verify that the NA1 instance still exists.
            Assert.True(client.TestConnection("https://na1.salesforce.com"));
        }        
    }
}