using netDumbster.smtp;
using TrainTicketing.Contracts.DataTransfer;

var builder = WebApplication.CreateBuilder(args);

var fakeSmtpServer = SimpleSmtpServer.Start(2525);
builder.Services.AddSingleton(fakeSmtpServer);

var app = builder.Build();


app.MapPost("/emails/send", async (SendEmailRequest request, ILogger<Program> logger) =>
{
});

app.Run();
