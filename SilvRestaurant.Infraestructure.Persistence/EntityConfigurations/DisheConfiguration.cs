using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Infraestructure.Persistence.EntityConfigurations
{
    public class DisheConfiguration : IEntityTypeConfiguration<Dishe>
    {
        public void Configure(EntityTypeBuilder<Dishe> builder)
        {
            builder.ToTable("Dishe");
            builder.HasKey(X => X.Id);
            builder.Property(x => x.Price).HasColumnType("Decimal").HasPrecision(12, 2);
            builder.HasOne(d => d.Category)
                .WithMany(c => c.Dishes)
                .HasForeignKey(d => d.IdCategory)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
