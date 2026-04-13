namespace TrainTicketing.Contracts.DataTransfer;

public record SendEmailRequest(
    string RecipientEmail,
    string Subject,
    string Body,
    Guid ReservationId
    );
