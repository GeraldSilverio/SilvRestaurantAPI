using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Infraestructure.Persistence.EntityConfigurations
{
    public class OrderDisheConfiguration : IEntityTypeConfiguration<OrderDishes>
    {
        public void Configure(EntityTypeBuilder<OrderDishes> builder)
        {
            builder.ToTable("OrderDishe");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Order)
                .WithMany(x => x.OrderDishes)
                .HasForeignKey(x => x.IdOrder)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(x => x.Dishe)
                .WithMany(x => x.OrderDishes)
                .HasForeignKey(x => x.IdDishe)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
