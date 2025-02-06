using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace TrainTicketing.Database;
internal class DbContext : IdentityDbContext<IdentityUser>
{
}
