using TrainTicketing.Contracts.DataTransfer;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/emails/send", async (SendEmailRequest request, ILogger<Program> logger) =>
{
});

app.Run();
