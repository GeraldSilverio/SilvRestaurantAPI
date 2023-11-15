using SilvRestaurant.Core.Domain.Commons;

namespace SilvRestaurant.Core.Domain.Entities
{
    public class OrderDishes:AuditableBaseEntity
    {
        public int IdOrder { get; set; }
        public int IdDishe { get; set; }
        public Order Order { get; set; }
        public Dishe Dishe { get; set; }
    }
}
