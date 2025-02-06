namespace TrainTicketing.Entities;
public class RouteDetail
{
    public int Id { get; }

    public int RouteId { get; }

    public Route? Route { get; }

    public int StationId { get; }

    public Station? Station { get; }

    public decimal DistanceFromMain {  get; }
}
