using System.ComponentModel.DataAnnotations;

namespace TrainTicketing.Contracts.DataTransfer;

public record SendEmailRequest(
    [EmailAddress]
    string RecipientEmail,
    string Subject,
    string Body,
    Guid ReservationId
    );
