using Microsoft.EntityFrameworkCore;
using SilvRestaurant.Core.Domain.Commons;
using SilvRestaurant.Core.Domain.Entities;
using SilvRestaurant.Infraestructure.Persistence.EntityConfigurations;

namespace SilvRestaurant.Infraestructure.Persistence.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new IngredientConfiguration());
            modelBuilder.ApplyConfiguration(new TableConfiguration());
            modelBuilder.ApplyConfiguration(new CategotyOfDisheConfiguration());
            modelBuilder.ApplyConfiguration(new DisheConfiguration());
            modelBuilder.ApplyConfiguration(new DisheIngredientConfiguration());
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.CreatedBy = "DefaultAppUser";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModified = DateTime.Now;
                        entry.Entity.LastModifiedBy = "DefaultAppUser";
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        //DbSet

        public DbSet<Ingredient> Ingredients { get; set;}
        public DbSet<Table> Tables { get; set;}
        public DbSet<CategoryOfDishe> CategoryOfDishes { get; set;}
        public DbSet<Dishe> Dishes { get; set;}
        public DbSet<DisheIngredient> DisheIngredients { get; set;}
    }
}
