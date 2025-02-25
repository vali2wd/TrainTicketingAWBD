using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Helpers
{
    public class SeedUsersRoles
    {
        private readonly List<IdentityRole> _roles;
        private readonly List<IdentityUser> _users;
        private readonly List<IdentityUserRole<string>> _userRoles;



        public SeedUsersRoles()
        {
            _roles = GetRoles();
            _users = GetUsers();
            _userRoles = GetUserRoles(_users, _roles);
        }

        public List<IdentityRole> Roles { get { return _roles; } }
        public List<IdentityUser> Users { get { return _users; } }
        public List<IdentityUserRole<string>> UserRoles { get { return _userRoles; } }
        private List<IdentityRole> GetRoles()
        {
            // Seed Roles
            var workerRole = new IdentityRole("Worker");
            workerRole.NormalizedName = workerRole.Name!.ToUpper();
            var clientRole = new IdentityRole("Client");
            clientRole.NormalizedName = clientRole.Name!.ToUpper();
            List<IdentityRole> roles = new List<IdentityRole>() {
        workerRole,
        clientRole
          };
            return roles;
        }
        private List<IdentityUser> GetUsers()
        {
            string pwd = "P@$$w0rd";
            var passwordHasher = new PasswordHasher<IdentityUser>();
            // Seed Users
            var workerUser = new IdentityUser
            {
                UserName = "worker@email.ro",
                Email = "worker@email.ro",
                EmailConfirmed = true,
            };
            workerUser.NormalizedUserName = workerUser.UserName.ToUpper();
            workerUser.NormalizedEmail = workerUser.Email.ToUpper();
            workerUser.PasswordHash = passwordHasher.HashPassword(workerUser, pwd);
            var clientUser = new IdentityUser
            {
                UserName = "client@email.ro",
                Email = "client@email.ro",
                EmailConfirmed = true,
            };
            clientUser.NormalizedUserName = clientUser.UserName.ToUpper();
            clientUser.NormalizedEmail = clientUser.Email.ToUpper();
            clientUser.PasswordHash = passwordHasher.HashPassword(clientUser, pwd);
            List<IdentityUser> users = new List<IdentityUser>() {
        workerUser,
        clientUser,
          };
            return users;
        }
        private List<IdentityUserRole<string>> GetUserRoles(List<IdentityUser> users, List<IdentityRole> roles)
        {
            // Seed UserRoles
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[0].Id,
                RoleId = roles.First(q => q.Name == "Worker").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[1].Id,
                RoleId = roles.First(q => q.Name == "Client").Id
            });
            return userRoles;
        }
    }
}

