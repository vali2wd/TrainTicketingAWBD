using TrainTicketing.Contracts.DataTransfer;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<ReservationReportDto> _reportStore = new();

// Receives reservations for BI data gathering.
app.MapPost("/reports/collect", (ReservationReportDto report) =>
{
    _reportStore.Add(report);
    Console.WriteLine($">>> [REPORTING] Logged reservation for {report.TrainName}. Total logs: {_reportStore.Count}");
    return Results.Accepted();
});

// Displays report data.
app.MapGet("/reports/stats", () =>
{
    var stats = new
    {
        TotalTicketsSold = _reportStore.Count,
        TotalRevenue = _reportStore.Sum(r => r.Price),
        PopularStations = _reportStore
            .GroupBy(r => r.DepartureStation)
            .Select(g => new { Station = g.Key, Count = g.Count() })
            .OrderByDescending(x => x.Count)
    };
    return Results.Ok(stats);
});

app.Run();