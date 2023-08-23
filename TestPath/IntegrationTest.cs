using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System.Net;
using TestingProject.Models;

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
            response.Should().BeSuccessful();
        }

        [Fact]
        public async Task UserAddCard_IntegrationTest()
        {
            //Arrange
            var card = new Card { Id = "6", Name = "Card 6", Stars = 6, Description = "This is Card Number.6", Type = "Ultra", Price = 600 };

            //Act
            var response = await client.PostAsync("/api/Card", new StringContent(JsonConvert.SerializeObject(card)));
            //Assert
            response.EnsureSuccessStatusCode();
            //Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
