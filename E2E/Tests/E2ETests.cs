using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using TrainTicketing.Contracts.DataTransfer;
using TrainTicketing.Database;

namespace E2E.Tests;

public class E2ETests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public E2ETests(WebApplicationFactory<Program> factory)
    {
        _factory = factory.WithWebHostBuilder(builder =>
        {
            builder.UseEnvironment("Test");
            builder.ConfigureTestServices(services =>
            {
                services
                    .AddAuthentication(defaultScheme: "TestScheme")
                    .AddScheme<AuthenticationSchemeOptions, TestAuthHandler>("TestScheme", options => { });
                services.AddAuthorization(options =>
                {
                    options.AddPolicy("ClientPolicy", policy =>
                    {
                        policy.AddAuthenticationSchemes("TestScheme"); // Force policy to check our fake scheme
                        policy.RequireAuthenticatedUser();
                        // If the real policy requires a role, add it here too
                        policy.RequireRole("Client");
                    });
                });
            });
        });
    }

    ///route/{routeId}/tariff", async (string routeId, TrainTicketingDbContext dbContext)
    [Fact]
    public async Task GetRoute_ReturnsNotFound_WhenRouteNotExist()
    {
        // Arrange.
        var client = _factory.CreateClient();
        using var scope = _factory.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<TrainTicketingDbContext>();
        var fakeRouteId = Guid.NewGuid();
        
        // Act
        var url = $"route/{fakeRouteId}/tariff";
        var response = await client.GetAsync(url);

        // Assert
        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }


    [Fact]
    public async Task GetDepartures_ReturnsCorrectRoutes_WhenDataExists()
    {
        // Arrange.
        var client = _factory.CreateClient();
        using var scope = _factory.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<TrainTicketingDbContext>();

        var sinaia = "62C14434-9039-412E-9E36-DCBD7CBBAE4F";
        var brasov = "66A74A29-282F-4FF9-B5D6-2F49D3D3536F";
        var travelDate = new DateTime(2025, 12, 01);

        // Act
        var url = $"/departures?departureStation={sinaia}&arrivalStation={brasov}&date={travelDate:yyyy-MM-dd}";
        var response = await client.GetAsync(url);

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        var results = await response.Content.ReadFromJsonAsync<List<dynamic>>();
        Assert.NotNull(results);
        // Verify that we found at least one route
        Assert.NotEmpty(results);
    }

    [Fact]
    public async Task CreateReservation_WhenConcurrent_ShouldFailForOneRequestDueToAtomicityOfDDD()
    {
        // Arrange, Auth Scheme.
        var client = _factory.CreateClient(new WebApplicationFactoryClientOptions
        {
            AllowAutoRedirect = false
        });
        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(scheme: "TestScheme");

        // Arrange, seat data.
        var dailyDepartureId = 1;
        var seatReservationRequest = new SeatReservationRequest(dailyDepartureId, 1, 4);

        // Act.
        var task1 = client.PostAsJsonAsync("/reserve-seat", seatReservationRequest);
        var task2 = client.PostAsJsonAsync("/reserve-seat", seatReservationRequest);

        // Wait for both to finish, In other words - 2 users reserve at the same time.
        await Task.WhenAll(task1, task2);
        var response1 = await task1;
        var response2 = await task2;
        var results = new List<HttpStatusCode> { response1.StatusCode, response2.StatusCode };

        // Check that any of the two requests is returned as a Bad Request, part of DDD mechanism of Version Increment.
        Assert.Contains(results, code => code == HttpStatusCode.Created);
        Assert.Contains(results, code => code == HttpStatusCode.BadRequest);
    }
}