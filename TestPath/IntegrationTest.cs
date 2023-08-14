using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace TestPath
{
    public class IntegrationTest
    {
        private readonly WebApplicationFactory<Program> server;
        private readonly HttpClient client;

        public IntegrationTest()
        {
            server = new WebApplicationFactory<Program>();
            client = server.CreateClient();
        }
        [Fact]
        public async Task UserGetAllCard_IntegrationTest()
        {
            //Arrange
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/Card");
            //Act
            var response = await client.SendAsync(request);
            //Assert
            response.EnsureSuccessStatusCode();
            //Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
