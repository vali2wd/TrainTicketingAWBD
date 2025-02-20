using TrainTicketing.DomainModel.Kernel;

namespace TrainTicketing.DomainModel.Aggregates.DailyDeparture;
public class ReservationAddedEvent : DomainEventBase
{
    public ReservationAddedEvent(int dailyDepartureId)
    {
        DailyDepartureId = dailyDepartureId;
    }
    public int DailyDepartureId { get; set; }
}
