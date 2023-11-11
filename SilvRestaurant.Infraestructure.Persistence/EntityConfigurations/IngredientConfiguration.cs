using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Infraestructure.Persistence.EntityConfigurations
{
    public class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.ToTable("Ingredient");
            builder.HasKey(X=> X.Id);
            
        }
    }
}
