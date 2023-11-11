using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SilvRestaurant.Core.Application.Enums;
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
                new CategoryOfDishe { Id = (int)CategoriesOfDishe.Entrada, Name = CategoriesOfDishe.Entrada.ToString() },
                new CategoryOfDishe { Id = (int)CategoriesOfDishe.PlatoFuerte, Name = CategoriesOfDishe.PlatoFuerte.ToString() },
                new CategoryOfDishe { Id = (int)CategoriesOfDishe.Postre, Name = CategoriesOfDishe.Postre.ToString() },
                new CategoryOfDishe { Id = (int)CategoriesOfDishe.Bebida, Name = CategoriesOfDishe.Bebida.ToString() }
                );
        }
    }
}
