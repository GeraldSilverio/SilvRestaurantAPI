using SilvRestaurant.Core.Domain.Commons;

namespace SilvRestaurant.Core.Domain.Entities
{
    public class DisheIngredient : AuditableBaseEntity
    {
        public int IdDishe { get; set; }
        public int IdIngredient { get; set; }
        public Dishe Dishe { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
