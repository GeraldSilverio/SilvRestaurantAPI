using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Infraestructure.Persistence.EntityConfigurations
{
    public class DisheIngredientConfiguration : IEntityTypeConfiguration<DisheIngredient>
    {
        public void Configure(EntityTypeBuilder<DisheIngredient> builder)
        {
            builder.ToTable("DisheIngredient");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Dishe)
                .WithMany(x => x.DisheIngredients)
                .HasForeignKey(x => x.IdDishe)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Ingredient)
                .WithMany(x => x.DisheIngredients)
                .HasForeignKey(x => x.IdIngredient)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
