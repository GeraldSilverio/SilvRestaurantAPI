using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Infraestructure.Persistence.EntityConfigurations
{
    public class TableConfiguration : IEntityTypeConfiguration<Table>
    {
        public void Configure(EntityTypeBuilder<Table> builder)
        {
            builder.ToTable("Table");
            builder.HasKey(x => x.Id);
            
        }
    }
}
