namespace WMS.Tests.Fakes
{
    public class TrainTicketingContextFakeBuilder : IDisposable
    {
        public readonly TrainTicketingContextFake _context = new();

        public TrainTicketingContextFakeBuilder()
        {
            _context.Database.EnsureCreated(); // Ensure the database is created and seeded
        }

        // Prolly later, maybe to have some products placed

        public TrainTicketingContextFake Build()
        {
            _context.SaveChanges();
            return _context;
        }

        public void Dispose()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }
    }
}
