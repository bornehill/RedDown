using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

using RedDown.Data.Entities;

namespace RedDown.Data
{
    public class RedDownContext : IdentityDbContext<AuthUser, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public RedDownContext(DbContextOptions<RedDownContext> options) : base(options) { }

        public DbSet<RegistryDown> RegistryDowns { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Questions> Questions { get; set; }

    }
}
