namespace TrainTicketing.Entities;
public class Route
{
    public Guid Id { get; set; }

    public string RouteName { get; set; } = null!;

    public Station MainTerminal { get; set; } = null!;

    public ICollection<RouteDetail> RouteDetails { get; set; } = [];
}
