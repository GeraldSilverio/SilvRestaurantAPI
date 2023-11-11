using SilvRestaurant.Core.Domain.Commons;

namespace SilvRestaurant.Core.Domain.Entities
{
    public class CategoryOfDishe:AuditableBaseEntity
    {
        public string Name { get; set; } = null!;

        public ICollection<Dishe> Dishes { get; set; }
    }
}
