using Moq;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using TrainTicketing.Services.SeatReservation;
using WMS.Tests.Fakes;
using Microsoft.Extensions.Logging.Abstractions;
using TrainTicketing.Contracts.DataTransfer;
using TrainTicketing.DomainModel.Entities;
using TrainTicketing.Errors;

public class SeatReservationServiceTests
{
    private TrainTicketingContextFakeBuilder contextFakeBuilder;
    private readonly Mock<UserManager<IdentityUser>> _mockUserManager;
    public SeatReservationServiceTests()
    {
        this.contextFakeBuilder = new();
        var userStore = new Mock<IUserStore<IdentityUser>>();
        _mockUserManager = new Mock<UserManager<IdentityUser>>(
            userStore.Object, null, null, null, null, null, null, null, null);
    }

    [Fact]
    public async Task ReserveSeat_ShouldReturnFailure_WhenDailyDepartureNotFound()
    {
        // Arrange
        var ctx = this.contextFakeBuilder.Build();
        var seatReservationService = new SeatReservationService(ctx, _mockUserManager.Object, NullLogger<SeatReservationService>.Instance);
        var seatReservationRequest = new SeatReservationRequest(int.MaxValue, 1, 1);
        var failureResult = Result<Reservation>.Failure(DepartureErrors.DepartureNotFound);

        // Act
        var result = await seatReservationService.ReserveSeatAsync(seatReservationRequest, null, CancellationToken.None);

        // Assert
        Assert.Equal(failureResult.IsFailure, result.IsFailure);
        Assert.Equal(failureResult.Error.Code, result.Error.Code);
    }

    [Fact]
    public async Task ReserveSeat_ShouldReturnFailure_WhenDepartureRouteDetailNotFound()
    {
        // Arrange
        var ctx = this.contextFakeBuilder.Build();
        var seatReservationService = new SeatReservationService(ctx, _mockUserManager.Object, NullLogger<SeatReservationService>.Instance);
        var seatReservationRequest = new SeatReservationRequest(1, int.MaxValue, 1);
        var failureResult = Result<Reservation>.Failure(DepartureErrors.DepartureDetailNotFound);
        // Act
        var result = await seatReservationService.ReserveSeatAsync(seatReservationRequest, null, CancellationToken.None);
        // Assert
        Assert.Equal(failureResult.IsFailure, result.IsFailure);
        Assert.Equal(failureResult.Error.Code, result.Error.Code);
    }

    [Fact]
    public async Task ReserveSeat_ShouldReturnFailure_WhenArrivalRouteDetailNotFound()
    {
        // Arrange
        var ctx = this.contextFakeBuilder.Build();
        var seatReservationService = new SeatReservationService(ctx, _mockUserManager.Object, NullLogger<SeatReservationService>.Instance);
        var seatReservationRequest = new SeatReservationRequest(1, 1, int.MaxValue);
        var failureResult = Result<Reservation>.Failure(DepartureErrors.ArrivalDetailNotFound);
        // Act
        var result = await seatReservationService.ReserveSeatAsync(seatReservationRequest, null, CancellationToken.None);
        // Assert
        Assert.Equal(failureResult.IsFailure, result.IsFailure);
        Assert.Equal(failureResult.Error.Code, result.Error.Code);
    }

    [Fact]
    public async Task ReserveSeat_WhenPickCorrect_ReturnsSuccessAndSeat()
    {
        var ctx = this.contextFakeBuilder.Build();
        var seatReservationService = new SeatReservationService(ctx, _mockUserManager.Object, NullLogger<SeatReservationService>.Instance);
        var seatReservationRequest = new SeatReservationRequest(1, 7, 8);
        var successResult = Result<Reservation>.Success(null);
        // Act

        var result = await seatReservationService.ReserveSeatAsync(seatReservationRequest, null, CancellationToken.None);

        // Assert
        Assert.Equal(successResult.IsSuccess, result.IsSuccess);
        Assert.IsType<Reservation>(result.Data);
        Assert.NotNull(result.Data);
    }
}
