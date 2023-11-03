using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SilvRestaurant.Infraestructure.Identity.Entities;

namespace SilvRestaurant.Infraestructure.Identity.Context
{
    public class IdentityContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("Identity");

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "Users");
            });

            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Roles");
            });

            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable(name: "UserRoles");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable(name: "UserLogins");
            });
        }
    }
}
