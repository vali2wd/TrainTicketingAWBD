using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TrainTicketing.Database;

namespace TrainTicketing
{
    public class TrainTicketingDbContextFactory : IDesignTimeDbContextFactory<TrainTicketingDbContext>
    {
        public TrainTicketingDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TrainTicketingDbContext>();

            var connectionString = "Server=localhost;Database=TrainTicketing;Trusted_Connection=True;TrustServerCertificate=True;";

            optionsBuilder.UseSqlServer(connectionString);

            return new TrainTicketingDbContext(optionsBuilder.Options);
        }
    }
}