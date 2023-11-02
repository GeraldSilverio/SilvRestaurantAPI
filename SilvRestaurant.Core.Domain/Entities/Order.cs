using SilvRestaurant.Core.Domain.Commons;

namespace SilvRestaurant.Core.Domain.Entities
{
    public class Order:AuditableBaseEntity
    {
        public decimal SubTotal { get; set; }
        public bool IsCompleted { get; set; }
    }
}
