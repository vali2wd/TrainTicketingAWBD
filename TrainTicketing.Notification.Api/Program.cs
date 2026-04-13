using netDumbster.smtp;
using System.Net.Mail;
using TrainTicketing.Contracts.DataTransfer;

var builder = WebApplication.CreateBuilder(args);

var fakeSmtpServer = SimpleSmtpServer.Start(2525);
builder.Services.AddSingleton(fakeSmtpServer);

var app = builder.Build();

app.MapPost("/emails/send", async (SendEmailRequest request, SimpleSmtpServer smtpServer, ILogger<Program> logger) =>
{
    logger.LogInformation(">>> Receiving request for Reservation: {Id}", request.ReservationId);

    using var client = new SmtpClient("localhost", 2525);
    var mailMessage = new MailMessage("system@trainticketing.com", request.RecipientEmail)
    {
        Subject = request.Subject,
        Body = request.Body
    };

    await client.SendMailAsync(mailMessage);
    return Results.Ok(new { status = "Sent to Internal SMTP Server" });
});


app.MapGet("/emails/inbox", (SimpleSmtpServer smtpServer) =>
{
    // This looks at the memory of netDumbster
    var received = smtpServer.ReceivedEmail.Select(e => new {
        To = e.ToAddresses,
        Subject = e.Subject,
        Body = e.MessageParts,
    });

    return Results.Ok(received);
});

app.Run();