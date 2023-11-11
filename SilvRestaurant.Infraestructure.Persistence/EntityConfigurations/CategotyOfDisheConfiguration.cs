using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Infraestructure.Persistence.EntityConfigurations
{
    public class CategotyOfDisheConfiguration : IEntityTypeConfiguration<CategoryOfDishe>
    {
        public void Configure(EntityTypeBuilder<CategoryOfDishe> builder)
        {
            builder.ToTable("CategotyOfDishe");
            builder.HasKey(c => c.Id);
            builder.HasData(
                new CategoryOfDishe { Id = 1, Name = "Entrada" },
                new CategoryOfDishe { Id = 2, Name = "Plato Fuerte" },
                new CategoryOfDishe { Id = 3, Name = "Postre" },
                new CategoryOfDishe { Id = 4, Name = "Bebida" }
                );
        }
    }
}
