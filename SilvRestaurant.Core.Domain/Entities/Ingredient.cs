using SilvRestaurant.Core.Domain.Commons;

namespace SilvRestaurant.Core.Domain.Entities
{
    public class Ingredient:AuditableBaseEntity
    {
        public string Name { get; set; } = null!;
    }
}
